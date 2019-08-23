using System;
using Entidades;
namespace Ingelagj.Controllers
{
    public class AutenticarUsuarioController : ApiController
    {
        Contexto contexto;
        public AutenticarUsuarioController()
        {
            contexto = FabricarContextos.fabricarContexto("lista");
        }

        /**
         * Verifica los datos 
         */
        public Boolean VerificarDatos(string CorreoElectronico, string Contraseña)
        {
            List<Usuarios> User = this.contexto.getUsuarios();
            List<int> m = new List<int>();

            foreach (Usuarios u in User)
            {
                if (u.getCorreoElectronico().equals(CorreoElectronico) && u.getContraseña().equals(Contraseña))
                {
                    return true;
                }

            }

            return false;
        }
    }
}

