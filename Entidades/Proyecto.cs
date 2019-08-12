using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Proyecto
    {
        string nombre;
        string estado;
        string modalidad;
        string fechaAprobacion;
        string fechaRadicacion;

        public Proyecto(string nombre, string estado, string modalidad, string fechaAprobacion, string fechaRadicacion)
        {
            this.Nombre = nombre;
            this.Estado = estado;
            this.Modalidad = modalidad;
            this.FechaAprobacion = fechaAprobacion;
            this.FechaRadicacion = fechaRadicacion;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Modalidad { get => modalidad; set => modalidad = value; }
        public string FechaAprobacion { get => fechaAprobacion; set => fechaAprobacion = value; }
        public string FechaRadicacion { get => fechaRadicacion; set => fechaRadicacion = value; }
    }
}
