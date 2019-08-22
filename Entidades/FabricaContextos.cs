using Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /**
     * Fabrica de contextos. Usese el metodo fabricarContexto("lista") para obtener la lista
     */
    public static class FabricaContextos
    {
        public static ListaContext lista;
        public static DesarrolloDbContext desarrolloDbContext;

        public static Contexto fabricarContexto(string tipo)
        {
            if (tipo.ToLower().Equals("lista"))
            {
                if(lista != null)
                {
                    lista = new ListaContext();
                }
                return lista;
            }
            else
            {
                return null;
            }
        }

    }
}
