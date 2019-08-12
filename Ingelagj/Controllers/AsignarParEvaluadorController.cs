using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class AsignarParEvaluadorController : ApiController
    {
        public Boolean verificarDocumento (string documento)
        {
            return true;
        }

        public ParEvaluador asignarPar (string documento, string nombre)
        {
            return ParEvaluador;
        }

        public Boolean guardarParEvaluador (string documento, string nomnbre)
        {
            return true;
        }
    }
}
