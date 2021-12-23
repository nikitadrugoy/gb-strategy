namespace Abstractions.Serialization
{
    public interface IDeserializer
    {
        T Deserialize<T>(string source);
    }
}