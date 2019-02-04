using Empregando.Domain.Entities;
using System;

namespace Empregando.Domain.Repositories
{
    public interface IAnuncioRepository
    {
        Anuncio Obter(Guid id);

        void Atualizar(Anuncio anuncio);
    }
}