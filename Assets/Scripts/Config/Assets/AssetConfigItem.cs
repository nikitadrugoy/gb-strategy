using UnityEngine;

namespace Config.Assets
{
    [CreateAssetMenu(fileName = "AssetConfigItem", menuName = "Config/AssetConfigItem", order = 0)]
    public class AssetConfigItem : ScriptableObject
    {
        [SerializeField] private string _id;
        [SerializeField] private Transform _prefab;

        public string Id => _id;
        public Transform Prefab => _prefab;
    }
}