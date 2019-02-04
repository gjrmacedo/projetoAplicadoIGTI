using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Empregando.API.App_Start
{
    public class SessaoUsuario
    {
        public SessaoUsuario()
        {

        }

        public static SessaoUsuario Usuario { get; }

        public Guid UsuarioId { get; set; }
        public string Token { get; set; }
    }
}