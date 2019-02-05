using Empregando.API.DTOs.Adapters;
using Empregando.API.DTOs.Requests;
using Empregando.Domain.CommandHandlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empregando.API.Controllers
{
    /// <summary>
    /// Anuncios
    /// </summary>
    [AllowAnonymous]
    public class AnunciosController : ApiController
    {
        private readonly AnuncioCommandHandler Handler;

        /// <summary>
        /// Publicar um novo anúncio
        /// </summary>
        [HttpPost]
        [Route("anuncios")]
        public IHttpActionResult Post([FromBody]dynamic value)
        {
            return Ok();
        }

        /// <summary>
        /// Editar um anúncio
        /// </summary>
        [HttpPut]
        [Route("anuncios")]
        public IHttpActionResult Put([FromBody]dynamic value)
        {
            return Ok();
        }

        /// <summary>
        /// Desativar um anúncio
        /// </summary>
        [HttpPut]
        [Route("anuncios/{id:guid}/inactive")]
        public IHttpActionResult Inactive([FromUri]Guid id) 
        {
            DesativarAnuncioRequest request = new DesativarAnuncioRequest();
            var command = CommandAdapter.ToDesativarAnuncioCommand(request); 

            Handler.Handle(command);

            return Ok();
        }

        /// <summary>
        /// Obter um anúncio pelo id
        /// </summary>
        [HttpGet]
        [Route("anuncios/{id:guid}")]
        public IHttpActionResult Get([FromUri]Guid id)
        {
            return Ok();
        }
    }
}
