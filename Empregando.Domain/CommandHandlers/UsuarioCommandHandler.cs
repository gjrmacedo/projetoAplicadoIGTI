using Empregando.Domain.Commands;
using System;

namespace Empregando.Domain.CommandHandlers
{
    public class UsuarioCommandHandler :
        ICommandHandler<RegistrarNovoUsuarioCommand>
    {

        public void Handle(RegistrarNovoUsuarioCommand command)
        {
            throw new NotImplementedException();
        }
    }
}
