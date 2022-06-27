using Grpc.Core;
using ProjetoGrpc;

namespace ProjetoGrpc.Services
{
    public class UsuarioService : Usuario.UsuarioBase
    {
        private readonly ILogger<UsuarioService> _logger;

        public UsuarioService(ILogger<UsuarioService> logger)
        {
            _logger = logger;
        }

        public override Task<UsuarioReply> EnvioUsuario(UsuarioRequest request, ServerCallContext context)
        {
            return Task.FromResult(new UsuarioReply
            {
                Nome = request.Nome,
                Endereco = request.Endereco,
                Email = request.Email,
                Mensagem = "Enviado com sucesso!"
            });
        }
    }
}