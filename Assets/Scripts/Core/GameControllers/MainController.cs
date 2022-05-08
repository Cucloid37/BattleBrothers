using System;
using UnityEngine;
using UserControlSystem;

namespace Core

{
    public class MainController : BaseController
    {
        private AllDescriptions _descriptions;

        private PrefabManager _prefabManager;
        // private ProfilePlayer _profilePlayer;
        private MapsController _mapsController;
        private UpdateController _updateController;
        
        private readonly MouseInput _mouseInput;

        public MainController(AllDescriptions descriptions, PrefabManager prefabManager, UpdateController updateController)
        {
            _descriptions = descriptions;
            _prefabManager = prefabManager;
            // _profilePlayer = profilePlayer;
            _updateController = updateController;

            _mouseInput = new MouseInput();
            _updateController.Add(_mouseInput);

            var x = _prefabManager.MapsPrefab[0];
            
            // PrefabManager 

            ProfilePlayer.CurrentState.SubscribeOnChange(ChangeState);
            ProfilePlayer.GameIsPaused.SubscribeOnChange(Pause);
            
            ProfilePlayer.CurrentState.Value = GameState.Maps;
        }

        private void ChangeState(GameState state)
        {
            switch (state)
            {
                case GameState.None:
                    break;
                case GameState.Maps:
                    _mapsController = new MapsController(_mouseInput, new MapsInitialisation(_descriptions));
                    break;
                case GameState.Battle:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(state), state, null);
            }
        }

        private void Pause(bool IsPause)
        {
            if (!IsPause)
            {
                Time.timeScale = 1.0f;
            }
            else
            {
                Time.timeScale = 0.0f;
            }
        }

        protected override void OnDispose()
        {
            _mapsController?.Dispose();
            _updateController?.Cleanup();
        }
    }
}