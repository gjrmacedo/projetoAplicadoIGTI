using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empregando.API.Controllers
{
    /// <summary>
    /// Empresas
    /// </summary>
    public class EmpresasController : ApiController
    {
        /// <summary>
        /// Cadastrar nova empresa
        /// </summary>
        [HttpPost]
        [Route("empresas")]
        public void Post([FromBody]dynamic value)
        {
        }

        /// <summary>
        /// Obter informações da empresa a partir do id
        /// </summary>
        [HttpGet]
        [Route("empresas/{id:guid}")]
        public IHttpActionResult Get(Guid id)
        {
            return Ok();
        }

        /// <summary>
        /// Atualizar informações de uma empresa
        /// </summary>
        [HttpPut]
        [Route("empresas")]
        public void Put([FromBody]dynamic value)
        {
        }

        /// <summary>
        /// Desativar uma empresa
        /// </summary>
        [HttpPut]
        [Route("empresas/{id:guid}/inactive")]
        public IHttpActionResult Inactive([FromUri]Guid id)
        {
            return Ok();
        }
    }
}
