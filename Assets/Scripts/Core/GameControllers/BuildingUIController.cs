using Abstractions;
using UserControlSystem;

namespace Core
{
    public class BuildingUIController : BaseController
    {
        
        
        public BuildingUIController()
        {
            ProfilePlayer.CurrentBuilding.SubscribeOnChange(StartBuildingUI);
        }

        private void StartBuildingUI(IBuildingModel building)
        {
            
        }
    }
}