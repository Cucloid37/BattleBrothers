namespace Maps
{
    public class MainController : BaseController
    {
        private AllDescriptions _descriptions;
        private ProfilePlayer _profilePlayer;
        private MapsController _mapsController;

        public MainController(AllDescriptions descriptions, ProfilePlayer profilePlayer)
        {
            _descriptions = descriptions;
            _profilePlayer = profilePlayer;
            
            _profilePlayer.CurrentState.SubscribeOnChange(ChangeState);
            _profilePlayer.CurrentState.Value = GameState.Maps;
        }

        private void ChangeState(GameState state)
        {
            switch (state)
            {
                case GameState.None:
                    break;
                case GameState.Maps:
                    _mapsController = new MapsController();
                    break;
            }
        }
    }
}