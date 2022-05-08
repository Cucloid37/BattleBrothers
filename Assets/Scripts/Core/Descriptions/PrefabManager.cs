using System.Collections.Generic;
using UnityEngine;

namespace Core
{
    public class PrefabManager
    {
        private AllDescriptions _descriptions;

        public GameObject[] MapsPrefab { get; private set; }
        public GameObject[] Buildings { get; private set; }

        public void SetMaps(GameObject[] GO)
        {
            MapsPrefab = GO;
        }

        public PrefabManager(AllDescriptions descriptions)
        {
            _descriptions = descriptions;
            MapsPrefab = new List<GameObject>(_descriptions.Maps.Count);
            Initialization();
        }

        private async void Initialization()
        {
            for (int i = 0; i < MapsPrefab.Capacity; i++)
            {
                var go = await _descriptions.Maps.GetView(i).ConfigureAwait(false);
                MapsPrefab.Add(go);
            }
        }
    }
}