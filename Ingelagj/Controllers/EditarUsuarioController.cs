using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class EditarUsuarioController : ApiController
    {
        Contexto contexto;
        private EditarUsuario(Usuario usuario)
        {
            contexto.UpdateUsuario(usuario);
        }

    }
}