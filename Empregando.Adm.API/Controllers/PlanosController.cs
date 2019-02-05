using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Empregando.API.Controllers
{
    public class Plano
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }

    /// <summary>
    /// Planos
    /// </summary>
    [AllowAnonymous]
    public class PlanosController : ApiController
    {
        /// <summary>
        /// Listar todos os planos
        /// </summary>
        [HttpGet]
        [Route("planos")]
        public IHttpActionResult Get()
        {
            var response = new List<Plano>()
            {
                new Plano() { Id = 1, Nome = "Experimental" },
                new Plano() { Id = 2, Nome = "Básico" },
                new Plano() { Id = 3, Nome = "Intermediário" },
                new Plano() { Id = 4, Nome = "Avançado" }
            };

            return Ok(response);
        }
    }
}
