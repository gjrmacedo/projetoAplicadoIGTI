using System;

namespace Empregando.Domain.Commands
{
    public class DesativarAnuncioCommand : Command
    {
        public DesativarAnuncioCommand(Guid anuncioId, Guid usuarioId)
        {
            AnuncioId = anuncioId;
            UsuarioId = usuarioId;
        }

        public Guid AnuncioId { get; set; }
        public Guid UsuarioId { get; set; }


        public override bool Valido()
        {
            if (default(Guid) == AnuncioId)
                return false;

            return true;
        }
    }
}