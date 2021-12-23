using UnityEngine;

namespace Config.Assets
{
    [CreateAssetMenu(fileName = "AssetConfig", menuName = "Config/Asset", order = 0)]
    public class AssetConfig : ScriptableObject
    {
        [SerializeField] private BuildingAssetConfig[] _buildings;

        public BuildingAssetConfig[] Buildings => _buildings;
    }
}