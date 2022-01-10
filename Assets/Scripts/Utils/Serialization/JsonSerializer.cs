using Newtonsoft.Json;
using Utils.Serialization.Abstractions;

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