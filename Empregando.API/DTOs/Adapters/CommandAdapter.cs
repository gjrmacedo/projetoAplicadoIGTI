using Empregando.API.App_Start;
using Empregando.API.DTOs.Requests;
using Empregando.Domain.Commands;


namespace Empregando.API.DTOs.Adapters
{
    public static class CommandAdapter
    {
        public static DesativarAnuncioCommand ToDesativarAnuncioCommand(DesativarAnuncioRequest request)
        {
            return new DesativarAnuncioCommand(request.Id, SessaoUsuario.Usuario.UsuarioId);
        }
    }
}