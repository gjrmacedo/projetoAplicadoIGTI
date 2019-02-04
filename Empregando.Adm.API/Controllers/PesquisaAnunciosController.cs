using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Empregando.API.Controllers
{
    /// <summary>
    /// Pesquisa Anuncios
    /// </summary>
    public class PesquisaAnunciosController : ApiController
    {
        /// <summary>
        /// Listagem completa de anúncios de vagas através dos filtros disponíveis
        /// </summary>
        [HttpGet]
        [Route("pesquisa_anuncios/filters={filters}")]
        public IHttpActionResult GetPesquisa()
        {
            return Ok();
        }


        /// <summary>
        /// Obter detalhamento do anúncio a partir do id
        /// </summary>
        [HttpGet]
        [Route("pesquisa_anuncios/anuncio_id={id}")]
        public IHttpActionResult GetDetalhe([FromUri]Guid id)
        {
            return Ok();
        }
    }
}
