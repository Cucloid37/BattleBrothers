using Abstractions;
using UnityEngine;

namespace Core
{
    public class BuildingModel : IBuildingModel
    {
        public SubscriptionProperty<string> name { get; }
        public SubscriptionProperty<BuildingType> type { get; }
        
        public IBuildingUI UI { get; }

        public BuildingModel(string name, BuildingType type, IBuildingUI UI)
        {
            this.name = new SubscriptionProperty<string>()
            {
                Value = name
            };
            this.type = new SubscriptionProperty<BuildingType>()
            {
                Value = type
            };
            
            this.UI = UI;
        }
    }
}