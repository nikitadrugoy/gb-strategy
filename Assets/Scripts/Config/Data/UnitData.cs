using Config.Assets;
using Newtonsoft.Json;

namespace Config.Data
{
    public class UnitData
    {
        [JsonProperty("id")] private string _id;
        [JsonProperty("health")] private int _health;

        public string Id => _id;
        public int Health => _health;

        public AssetConfigItem AssetConfigItem { get; set; }
    }
}