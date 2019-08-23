using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Entidades;

namespace Ingelagj.Controllers
{
    public class GenerarFormatoEvaluacionController : ApiController
    {
        Contexto contexto;
        /**
         * Simulará la lista de puntajes acumulados para calcular el promedio y luego ser asignado al proyecto
         */
        List<int> PuntajesFormatos;
        public GenerarEvaluacionProyectoController(List<int> puntajes)
        {
            contexto = FabricarContextos.fabricarContexto("lista");
            PuntajesFormatos = puntajes;
        }
        /**
         * Verifica que ninguno de los puntajes se salga del rango establecido.
         */
        public Boolean VerificarPuntaje()
        {
            foreach(int puntaje in this.PuntajesFormatos)
            {
                if( puntaje>5 || puntaje<0)
                {
                    return false;
                }
            }
            return true;
        }

        /**
         * Calcula el puntaje total obtenido en el proyecto
         * 
         */
        public int CalcularPuntajeTotal()
        {
            int totalPuntaje = 0;
            if(VerificarPuntaje())
            {
                foreach (int puntaje in PuntajesFormatos)
                {
                    totalpuntaje = totalPuntaje + puntaje;
                }
                return (totalPuntaje / PuntajesFormatos.Count());
            }
            
        }




        public void asignarPuntajeProyecto(String codigoProyecto)
        {
            foreach (Proyecto p in contexto.getProyectos())
            {
                if (p.getCodigo().Equals(codigoProyecto))
                {
                    p.setPuntaje(CalcularPuntajeTotal());
                }
            }
        }
        



    }
}