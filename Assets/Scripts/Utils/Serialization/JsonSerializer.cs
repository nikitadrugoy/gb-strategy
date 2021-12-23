using Abstractions.Serialization;
using Newtonsoft.Json;

namespace Utils.Serialization
{
    public class JsonSerializer : IDeserializer
    {
        public T Deserialize<T>(string source)
        {
            return JsonConvert.DeserializeObject<T>(source);
        }
        
        // TODO add ISerializer
    }
}