namespace Maps
{
    public class ProfilePlayer
    {
        public SubscriptionProperty<GameState> CurrentState;

        public ProfilePlayer()
        {
            CurrentState = new SubscriptionProperty<GameState>();
        }
    }
}