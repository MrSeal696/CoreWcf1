public class Service : IService
{
    public string GetData(string name)
    {
        return $"Hello, {name}";
    }
}