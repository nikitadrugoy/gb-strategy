using UnityEngine;

namespace Config.Assets
{
    [CreateAssetMenu(fileName = "BuildingAssetConfig", menuName = "Config/Building", order = 0)]
    public class BuildingAssetConfig : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private Transform _prefab;

        public string Id => _id;
        public Transform Prefab => _prefab;
    }
}