using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class Starter : MonoBehaviour
    {
        [SerializeField] private AllDescriptions _descriptions;
        // private ProfilePlayer _profilePlayer;
        
        private MainController _mainController;
        private UpdateController _updateController;
        private PrefabManager _prefabManager;

        private async void Start()
        {
            // _profilePlayer = new ProfilePlayer();

            _updateController = new UpdateController();
           
        }
    }
}

