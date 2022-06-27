//using Microsoft.AspNetCore.Server.Kestrel.Core;
using ProjetoGrpc.Services;
//using System.Net;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGrpc();

//Setando para http/3
/*builder.WebHost.ConfigureKestrel((context, options) =>
{
    options.Listen(IPAddress.Any, 5001, listenOptions =>
    {
        listenOptions.Protocols = HttpProtocols.Http3;
        listenOptions.UseHttps();
    });
});*/

var app = builder.Build();

app.MapGrpcService<GreeterService>();
app.MapGrpcService<UsuarioService>();

app.MapGet("/", () => "Communication with gRPC endpoints must be made through a gRPC client. To learn how to create a client, visit: https://go.microsoft.com/fwlink/?linkid=2086909");

app.Run();
