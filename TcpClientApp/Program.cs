using System;
using System.ServiceModel;

class Program
{
    static void Main()
    {
        var binding = new NetTcpBinding();

        var endpoint = new EndpointAddress("net.tcp://localhost:808/nettcp");

        var factory = new ChannelFactory<IService>(binding, endpoint);
        var client = factory.CreateChannel();

        var result = client.GetData("TCP Client");
        Console.WriteLine(result);
    }
}