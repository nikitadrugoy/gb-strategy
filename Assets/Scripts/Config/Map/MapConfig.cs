using System.Collections.Generic;
using Newtonsoft.Json;

namespace Config.Map
{
    // TODO Переделать в Save/Load и перенести
    
    public class MapConfig
    {
        [JsonProperty("buildings")] private MapBuildingData[] _buildings;

        public IReadOnlyCollection<MapBuildingData> Buildings => _buildings;
    }
}