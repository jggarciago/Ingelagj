using Entidades;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class CargarSARAController : ApiController
    {
        Contexto contexto;

        public CargarSARAController()
        {
            contexto = FabricaContextos.fabricarContexto("lista");
        }
        /**
         * Currently not working
         */
        // POST api/values
        [HttpPost, Route("api/upload")]
        public async Task<IHttpActionResult> Post()
        {
            if (!Request.Content.IsMimeMultipartContent())
                throw new HttpResponseException(HttpStatusCode.UnsupportedMediaType);

            var provider = new MultipartMemoryStreamProvider();
            await Request.Content.ReadAsMultipartAsync(provider);
            foreach (var file in provider.Contents)
            {
                var filename = file.Headers.ContentDisposition.FileName.Trim('\"');
                var buffer = await file.ReadAsByteArrayAsync();
                //Todo usar archivo
            }

            return Ok();
        }

        private bool ValidarArchivo(HttpContent file)
        {
            return false;
        }

        private bool CargarArchivo(HttpContent file)
        {
            return false;
        }
    }
}
