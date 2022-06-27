using Grpc.Net.Client;
using ProjetoGrpc;
//using System.Net;


//Para http/3
/*
 * https://devblogs.microsoft.com/dotnet/http-3-support-in-dotnet-6/
var httpClient = new HttpClient();
httpClient.DefaultRequestVersion = HttpVersion.Version30;
httpClient.DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact;

var channel = GrpcChannel.ForAddress("https://localhost:7044", new GrpcChannelOptions() { HttpClient = httpClient });
*/


//Criando um canal
var channel = GrpcChannel.ForAddress("https://localhost:7044");


//Criando um client
var client = new Greeter.GreeterClient(channel);

//Buscando a reposta
var reply = await client.SayHelloAsync(
     new HelloRequest { Name = "Márcio"});

Console.WriteLine("Retorno do servidor: " + reply.Message);


//Usuario
var clientUsuario = new Usuario.UsuarioClient(channel);

//Buscando a reposta do usuario
var replyUsuario = await clientUsuario.EnvioUsuarioAsync(
     new UsuarioRequest { 
         Nome = "Marcio Krüger",
         Email = "teste@gmail.com",
         Endereco = "Rua de teste"
     });

Console.WriteLine(replyUsuario.Nome + " com o e-mail "+ replyUsuario.Email + " foi "+ replyUsuario.Mensagem);