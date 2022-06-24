using Grpc.Net.Client;
using ProjetoGrpc;

var channel = GrpcChannel.ForAddress("https://localhost:7044");
var client = new Greeter.GreeterClient(channel);

var reply = await client.SayHelloAsync(
     new HelloRequest { Name = "Márcio"});

Console.WriteLine("Retorno do servidor: " + reply.Message);