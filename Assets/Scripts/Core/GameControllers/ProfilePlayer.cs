using Abstractions;
using UnityEngine;

namespace Core
{
    public static class ProfilePlayer
    {
        public static SubscriptionProperty<GameState> CurrentState = new SubscriptionProperty<GameState>();
        public static SubscriptionProperty<IBuildingModel> CurrentBuilding = new SubscriptionProperty<IBuildingModel>();
        public static SubscriptionProperty<bool> GameIsPaused = new SubscriptionProperty<bool>();
        public static SubscriptionProperty<Transform> LastClickTarget = new SubscriptionProperty<Transform>();

        /*public ProfilePlayer()
        {
            CurrentState = new SubscriptionProperty<GameState>();
            GameIsPaused = new SubscriptionProperty<bool>();
            LastClickTarget = new SubscriptionProperty<Transform>();
        }*/

        public static void Initialization()
        {
            throw new System.NotImplementedException();
        }
    }
}