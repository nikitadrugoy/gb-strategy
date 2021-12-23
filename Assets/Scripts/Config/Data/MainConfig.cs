using System.Collections.Generic;
using System.Linq;
using Config.Assets;
using Newtonsoft.Json;

namespace Config.Data
{
    public class MainConfig
    {
        [JsonProperty("buildings")] private BuildingData[] _buildings;
        
        private Dictionary<string, BuildingData> _buildingByIds;

        public IReadOnlyDictionary<string, BuildingData> Buildings => _buildingByIds;
        
        public void Init(AssetConfig assetConfig)
        {
            _buildingByIds = _buildings.ToDictionary(item => item.Id);

            foreach (BuildingAssetConfig buildingAssetConfig in assetConfig.Buildings)
            {
                _buildingByIds[buildingAssetConfig.Id].AssetConfig = buildingAssetConfig;
            }
        }
    }
}