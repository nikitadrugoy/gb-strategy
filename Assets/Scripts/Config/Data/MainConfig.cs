using System.Collections.Generic;
using System.Linq;
using Config.Assets;
using Newtonsoft.Json;
using UnityEngine;

namespace Config.Data
{
    public class MainConfig
    {
        [JsonProperty("buildings")] private BuildingData[] _buildings;
        [JsonProperty("units")] private UnitData[] _units;
        
        private Dictionary<string, BuildingData> _buildingByIds;
        private Dictionary<string, UnitData> _unitByIds;

        public IReadOnlyDictionary<string, BuildingData> Buildings => _buildingByIds;
        public IReadOnlyDictionary<string, UnitData> Units => _unitByIds;
        
        public void Init(AssetConfig assetConfig)
        {
            InitBuildings(assetConfig);
            InitUnits(assetConfig);
        }
        
        private void InitBuildings(AssetConfig assetConfig)
        {
            _buildingByIds = _buildings.ToDictionary(item => item.Id);

            foreach (AssetConfigItem assetConfigItem in assetConfig.Buildings)
            {
                _buildingByIds[assetConfigItem.Id].AssetConfigItem = assetConfigItem;
            }
        }
        
        private void InitUnits(AssetConfig assetConfig)
        {
            _unitByIds = _units.ToDictionary(item => item.Id);

            foreach (AssetConfigItem assetConfigItem in assetConfig.Units)
            {
                _unitByIds[assetConfigItem.Id].AssetConfigItem = assetConfigItem;
            }
        }
    }
}