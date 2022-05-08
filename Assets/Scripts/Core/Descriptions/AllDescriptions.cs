using UnityEngine;

namespace Core
{
    [CreateAssetMenu(fileName = "AllDescriptions", menuName = "Descriptions/AllDescriptions")]
    public class AllDescriptions : ScriptableObject
    {
        [SerializeField] private MapsDescriptions _maps;
        [SerializeField] private BuildingDescriptions _building; 

        public MapsDescriptions Maps => _maps;
        public BuildingDescriptions Building => _building;
    }
}