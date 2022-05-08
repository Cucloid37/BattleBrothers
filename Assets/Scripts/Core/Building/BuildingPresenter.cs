using Abstractions;

namespace Core
{
    public class BuildingPresenter
    {
        private readonly BuildingView _view;
        private readonly IBuildingModel _model;

        public BuildingPresenter(BuildingView view, IBuildingModel model)
        {
            _view = view;
            _model = model;

            _view.OnTrigger += ExitInBuilding;
            
        }

        private void ExitInBuilding()
        {
            ProfilePlayer.CurrentBuilding.Value = _model;
            ProfilePlayer.CurrentState.Value = GameState.Window;
        }
        
    }
}