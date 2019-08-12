using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class AsigarPuntosController : ApiController
    {
        public Boolean verificarDocumento(string documento)
        {
            return true;
        }

        public Boolean verificarInfoProyecto (string documento)
        {
            return true;
        }

        public Proyecto buscarProyecto (string documento)
        {
            return Proyecto;
        }

        public Boolean verificarPromedio (string promedio)
        {
            return true;
        }

        public Boolean validarPuntos (string puntos, string promedio)
        {
            return true;
        }
    }
}