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
         * @Param String CorreoElectrónico, representa el correo electrónico del usuario al que se buscará que coincida
         * @Param String contraseña, representa la contraseña del usuario al que se buscará una coincidencia
         */
        public Boolean VerificarDatos(string CorreoElectronico, string Contraseña)
        {
            List<Usuarios> User = this.contexto.getUsuarios();


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

