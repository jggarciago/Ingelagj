using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class AutenticarUsuarioController : ApiController
    {
        Contexto contexto;
        public AutenticarUsuarioController()
        {
            contexto = FabricarContextos.fabricarContexto("lista");
        }
        public Boolean VerificarDatos(string CorreoElectronico, string Contraseña)
        {
            return true;
        }
    }
}

