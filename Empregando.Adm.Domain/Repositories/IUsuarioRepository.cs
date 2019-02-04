using Empregando.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Empregando.Domain.Repositories
{
    public interface IUsuarioRepository
    {
        bool VerificarEmail(string email);
        void Inserir(Usuario usuario);
        void Atualizar(Usuario usuario);
        Usuario Obter(Usuario usuario);
    }
}
