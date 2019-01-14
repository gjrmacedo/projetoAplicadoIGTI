using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empregando.API.Controllers
{
    /// <summary>
    /// Usuários
    /// </summary>
    public class UsuariosController : ApiController
    {
        /// <summary>
        /// Cadastrar um novo usuário
        /// </summary>
        [HttpPost]
        [Route("usuarios")]
        public void Post([FromBody]dynamic value)
        {

        }

        /// <summary>
        /// Autenticar o usuário
        /// </summary>
        [HttpPost]
        [Route("usuarios/auth")]
        public void Auth([FromBody]dynamic value)
        {
        }

        /// <summary>
        /// Obter informações do usuário a partir do id
        /// </summary>
        [HttpGet]
        [Route("usuarios")]
        public IHttpActionResult Get(Guid id)
        {
            return Ok();
        }

        /// <summary>
        /// Listar anuncios do usuário
        /// </summary>
        [HttpGet]
        [Route("usuarios/anuncios")]
        public IHttpActionResult GetAnuncios()
        {
            return Ok();
        }

        /// <summary>
        /// Listar empresas do usuário
        /// </summary>
        [HttpGet]
        [Route("usuarios/empresas")]
        public IHttpActionResult GetEmpresas()
        {
            return Ok();
        }

        /// <summary>
        /// Atualizar informações do usuário
        /// </summary>
        [HttpPut]
        [Route("usuarios")]
        public void Put([FromBody]dynamic value)
        {
        }
    }
}
