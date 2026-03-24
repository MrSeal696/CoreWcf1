using CoreWCF;

[ServiceContract]
public interface IService
{
    [OperationContract]
    string GetData(string name);
}