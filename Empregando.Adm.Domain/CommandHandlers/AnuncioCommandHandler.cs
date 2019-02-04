using Empregando.Domain.Commands;
using Empregando.Domain.Repositories;
using System;

namespace Empregando.Domain.CommandHandlers
{
    public class AnuncioCommandHandler : ICommandHandler<DesativarAnuncioCommand>
    {
        private readonly IAnuncioRepository AnuncioRepository;

        public AnuncioCommandHandler(IAnuncioRepository anuncioRepository)
        {
            AnuncioRepository = anuncioRepository;
        }

        public void Handle(DesativarAnuncioCommand command)
        {
            if (!command.Valido())
                throw new Exception("Comando inválido.");

            var anuncio = AnuncioRepository.Obter(command.AnuncioId);
            anuncio.Desativar();
            AnuncioRepository.Atualizar(anuncio);
        }
    }
}
