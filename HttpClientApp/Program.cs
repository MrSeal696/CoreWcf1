using System;
using System.ServiceModel;

class Program
{
    static void Main()
    {
        var binding = new BasicHttpBinding();


        var endpoint = new EndpointAddress("http://localhost:5028/http");

        var factory = new ChannelFactory<IService>(binding, endpoint);
        var client = factory.CreateChannel();

        var result = client.GetData("HTTP Client");
        Console.WriteLine(result);
    }
}