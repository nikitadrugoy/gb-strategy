using System.Collections.Generic;
using UnityEngine;

namespace Config.Assets
{
    [CreateAssetMenu(fileName = "AssetConfig", menuName = "Config/AssetConfig", order = 0)]
    public class AssetConfig : ScriptableObject
    {
        [SerializeField] private AssetConfigItem[] _buildings;
        [SerializeField] private AssetConfigItem[] _units;

        public IEnumerable<AssetConfigItem> Buildings => _buildings;
        public IEnumerable<AssetConfigItem> Units => _units;
    }
}