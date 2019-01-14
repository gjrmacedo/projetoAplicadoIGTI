using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Empregando.API.Controllers
{
    /// <summary>
    /// Planos
    /// </summary>
    [AllowAnonymous]
    public class PlanosController : ApiController
    {
        /// <summary>
        /// Obter o plano pelo id
        /// </summary>
        [HttpGet]
        [Route("planos/{id}")]
        public async Task<IHttpActionResult> Get([FromUri]Guid id)
        {
            System.Threading.Thread.Sleep(5000);

            return Ok(0);
        }

        /// <summary>
        /// Listar todos os planos
        /// </summary>
        [HttpGet]
        [Route("planos")]
        public IHttpActionResult Get()
        {
            return Ok();
        }
    }
}
