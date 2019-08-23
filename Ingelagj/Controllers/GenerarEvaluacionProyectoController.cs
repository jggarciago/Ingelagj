using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Ingelagj.Controllers
{
    public class GenerarEvaluacionProyectoController : ApiController
    {
        Contexto contexto;
        /**
         * Simulará la lista de formatos correspondientes al proyecto a calificar, estos formatos en realidad
         * deberían ser formularios pero para elementos practicos diremos que es un string
         */
        List<String> Formatos;
        public GenerarEvaluacionProyectoController()
        {
            contexto = FabricarContextos.fabricarContexto("lista");
            Formatos = new List<string>();
        }
        /**
         * Busca el formato correspondiente a la modalidad del proyecto para que el par evaluador pueda realizar 
         * la respectiva calificación.
         * @Param string codigoProyecto -> Codigo de proyecto al que se le buscará el respectivo formato
         */
        public string BuscarFormatoEvaluacion(string CodigoProyecto)
        {
            Proyecto p = BuscarProyecto(CodigoProyecto);
            foreach (String f in Formatos)
            {
                if(p.getModalidad().equals(f))
                {
                    return f;
                }
            }
        }

        /**
         * Busca el proyecto correspondiente al codigo enviado por parámetro
         * @Param string codigoProyecto -> Codigo del proyecto a ser retornado.
         */
        public Proyecto BuscarProyecto(string CodigoProyecto)
        {
            List<Proyecto> Proyectos = this.contexto.getProyectos();

            foreach(Proyecto p in Proyectos)
            {
                if(p.getCodigo().equals(CodigoProyecto))
                {
                    return p;
                }
            }
        }



    }
}
