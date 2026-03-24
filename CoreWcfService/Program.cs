using CoreWCF;
using CoreWCF.Configuration;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddServiceModelServices();

var app = builder.Build();

app.UseServiceModel(serviceBuilder =>
{
    serviceBuilder.AddService<Service>();

    serviceBuilder.AddServiceEndpoint<Service, IService>(
        new BasicHttpBinding(),
        "http://localhost:5028/http");

    serviceBuilder.AddServiceEndpoint<Service, IService>(
        new NetTcpBinding(),
        "net.tcp://localhost:808/nettcp");
});

app.Run();