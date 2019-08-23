using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class AgregarUsuarioController : ApiController
    {
        Contexto contexto;

        private AgregarUsuario(Usuario usuario)
        {
            contexto.AddUsuario(usuario);
        }

        //GET api/values//

        public Usuarios <Docentes> Get(Usuario usuario)
        {
            return contexto.Docentes;
        }

    }
}
