using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.AddressableAssets;

namespace Core
{
    [CreateAssetMenu(fileName = "Maps", menuName = "Descriptions/Maps")]
    public class MapsDescriptions : ScriptableObject
    {
        [SerializeField] private Map[] maps;

        public int Count => maps.Length;

        public Dictionary<int, Task<GameObject>> GetMapsDictionary()
        {
            return null;
        }
            
        public async Task<GameObject> GetView(int index)
        {
            // var dictionary = GetMapsDictionary();
            var reference = maps[index].Reference;
            return await Addressables.LoadAssetAsync<GameObject>(reference).Task.ConfigureAwait(false);
        }

        public Transform[] GetSpawnPoints(int index)
        {
            return maps[index].SpawnPoints;
        }
    }

    public enum TypeMap
    {
        example,
        simple
    }

    [Serializable]
    public class Map
    {
        [SerializeField] private int index;
        [SerializeField] private AssetReference reference;
        [SerializeField] private Transform[] spawnPoints;

        public AssetReference Reference => reference;
        public int Index => index;

        public Transform[] SpawnPoints => spawnPoints;
    }
    
    
    public interface IMapModel
    {
        // нужна ли модель?
    }

    public class MapModel : IMapModel
    {

        public MapModel()
        {
            
        }

    }
}