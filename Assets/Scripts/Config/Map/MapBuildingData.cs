using Newtonsoft.Json;
using UnityEngine;

namespace Config.Map
{
    public class MapBuildingData
    {
        [JsonProperty("id")] private string _id;
        [JsonProperty("position")] private Vector3 _position;

        public string Id => _id;
        public Vector3 Position => _position;
    }
}