using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class CargarSARAController : ApiController
    {
        // POST api/values
        public void Post(HttpContent file)
        {
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
