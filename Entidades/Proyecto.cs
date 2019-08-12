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
            this.nombre = nombre;
            this.estado = estado;
            this.modalidad = modalidad;
            this.fechaAprobacion = fechaAprobacion;
            this.fechaRadicacion = fechaRadicacion;
        }
    }
}
