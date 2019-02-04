using System;

namespace Empregando.Domain.Entities
{
    public class Anuncio
    {
        public Guid Id { get; protected set; }

        public bool Ativo { get; protected set; }

        public Anuncio(Guid id, bool ativo)
        {
            Id = id;
            Ativo = ativo;
        }

        public void Desativar()
        {
            Ativo = false;
        }
    }
}