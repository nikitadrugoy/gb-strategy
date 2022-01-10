using System.Collections.Generic;
using Newtonsoft.Json;

namespace Config.Map
{
    // TODO Переделать в Save/Load и перенести
    
    public class MapConfig
    {
        [JsonProperty("buildings")] private MapBuildingData[] _buildings;
        [JsonProperty("units")] private MapUnitData[] _units;

        public IReadOnlyCollection<MapBuildingData> Buildings => _buildings;
        public IReadOnlyCollection<MapUnitData> Units => _units;
    }
}