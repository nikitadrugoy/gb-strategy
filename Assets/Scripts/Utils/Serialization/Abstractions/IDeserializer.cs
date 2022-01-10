namespace Utils.Serialization.Abstractions
{
    public interface IDeserializer
    {
        T Deserialize<T>(string source);
    }
}