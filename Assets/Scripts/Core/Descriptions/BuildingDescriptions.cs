using System;
using System.Collections.Generic;
using System.Linq;
using Abstractions;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.UI;
using UserControlSystem;

namespace Core
{
    [CreateAssetMenu(fileName = "Building", menuName = "Descriptions/Building")]
    public class BuildingDescriptions : ScriptableObject
    {
        [SerializeField] private List<BuildingInfo> _buildings;

        [Serializable]
        private struct BuildingInfo
        {
            [SerializeField] public BuildingType type;
            [SerializeField] public AssetReference reference;
            [SerializeField] public string name;
            [SerializeField] public BuildingUI _UI;

            // здесь же мы получаем модельные данные объекта
            // и передаём их через метод GetModel
        }

        public AssetReference GetReference(BuildingType type)
        {
            var info = _buildings.FirstOrDefault(info => info.type == type);
            if (info.reference == null)
            {
                throw new InvalidOperationException($"This type {nameof(type)} not found");
            }

            return info.reference;
        }

        public IBuildingModel GetModel(BuildingType type)
        {
            var info = _buildings.FirstOrDefault(info => info.type == type);
            if (info.reference == null)
            {
                throw new InvalidOperationException($"This type {nameof(type)} not found");
            }
            
            return new BuildingModel(info.name, info.type);
        }
    }

    public enum BuildingType
    {
        One,
        Two
    }
}