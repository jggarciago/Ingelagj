using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Ingelagj.Controllers;

namespace Ingelagj.Controllers
{
    public class AsignarParEvaluadorController : ApiController
    {
        public Boolean verificarDocumento (string documento)
        {
            return true;
        }

        public AsigarPuntosController asignarPar (string documento, string nombre)
        {
            AsigarPuntosController p = new AsigarPuntosController();
            return p;
        }

        public Boolean guardarParEvaluador (string documento, string nomnbre)
        {
            return true;
        }
    }
}
