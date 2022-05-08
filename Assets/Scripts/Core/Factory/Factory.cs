using UnityEngine;
using Object = UnityEngine.Object;

namespace Core
{
    public class Factory
    {
        public GameObject CreateObject(GameObject prefab, Vector3 position)
        {
           return Object.Instantiate(prefab, position, Quaternion.identity);
        }
    }
}