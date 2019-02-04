using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;

namespace Empregando.Relatorios.API.Controllers
{
    public class VagasController : ApiController
    {
        // GET: Vagas
        [HttpGet]
        [Route("vagas")]
        public IHttpActionResult Get()
        {
            return Ok(
                new List<string>
                {
                    "Vaga1",
                    "Vaga2",
                    "Vaga3",
                    "Vaga4",
                    "Vaga4"
                }
            );
        }
    }
}