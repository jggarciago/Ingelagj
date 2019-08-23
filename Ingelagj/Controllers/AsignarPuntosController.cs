using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entidades;
namespace Ingelagj.Controllers
{
    public class AsignarPuntosController : ApiController
    {
        Contexto contexto;

        public AsignarPuntosController()
        {
            contexto = FabricaContextos.fabricarContexto("lista");
        }


        public Boolean verificarDocumento(string documento)
        {
            
            foreach (Docente d in contexto.Docentes())
            {
                if (d.Documento.Equals(documento))
                {
                    return true;
                }
            }
            
            return false;
        }

        public Boolean verificarInfoProyecto (string codigo)
        {
            foreach (Proyecto dp in contexto.Proyectos())
            {
                if (dp.Codigo.Equals(codigo))
                {
                    return true;
                }
            }

            return false;
        }

        public Boolean verificarPromedio (string promedio)
        {
            return true;
        }

        public Boolean validarPuntos (int puntaje)
        {
            int puntajeTotal; 

            foreach (Proyecto pr in contexto.Proyectos())
            {
                puntajeTotal = puntaje*4600;
                
            }

            return true;
        }
    }
}