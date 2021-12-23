using Abstractions.Serialization;
using Config.Assets;
using Config.Data;
using Config.Map;

namespace Config
{
    public class ConfigLoader
    {
        private readonly IDeserializer _deserializer;

        public ConfigLoader(IDeserializer deserializer)
        {
            _deserializer = deserializer;
        }
        
        public MainConfig LoadMainConfig(AssetConfig assetConfig, string dataConfigJson)
        {
            var mainConfig = _deserializer.Deserialize<MainConfig>(dataConfigJson);
            
            mainConfig.Init(assetConfig);

            return mainConfig;
        }

        public MapConfig LoadMapConfig(string mapConfigJson)
        {
            return _deserializer.Deserialize<MapConfig>(mapConfigJson);
        }
    }
}