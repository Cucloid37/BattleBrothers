using Core;
using UnityEngine;

namespace Abstractions
{
    
    public interface IBuildingModel
    {
        SubscriptionProperty<string> name { get; }
        SubscriptionProperty<BuildingType> type { get; }

        IBuildingUI UI { get; }
    }
}