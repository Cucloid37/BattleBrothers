namespace Core
{
    public class MapsInitialisation
    {
        private MapsFactory _factory;
        private AllDescriptions _descriptions;
        
        public MapsInitialisation(AllDescriptions descriptions)
        {
            _descriptions = descriptions;

            // скорее всего здесь идёт полнейшая лажа, завтра буду исправлять
            var dictionary = _descriptions.Maps.GetMapsDictionary();
            
            _factory = new MapsFactory(_descriptions, dictionary);

            var maps = _factory.CreateMaps(0); // заглушка
        }
    }
}