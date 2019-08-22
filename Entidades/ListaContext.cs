using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    /**
     * Clase de fachada para la base de datos.
     */
    class ListaContext : Contexto
    {
        public List<Docente> Docentes { get; set; }
        public List<FuncionarioDesarollo> Funcionarios { get; set; }
        public List<ParEvaluador> Pares { get; set; }
        public List<Proyecto> Proyectos { get; set; }

        public List<Usuario> Usuarios { get; set; }

        public ListaContext()
        {
            Docentes = new List<Docente>();
            Funcionarios = new List<FuncionarioDesarollo>();
            Pares = new List<ParEvaluador>();
            Proyectos = new List<Proyecto>();
            Usuarios = new List<Usuario>();
        }

        public void AddDocente(Docente newDocente)
        {
            Docentes.Add(newDocente);
        }

        public void AddFuncionario(FuncionarioDesarollo newFuncionario)
        {
            Funcionarios.Add(newFuncionario);
        }

        public void AddParEvaluador(ParEvaluador newParEvaluador)
        {
            Pares.Add(newParEvaluador);
        }

        public void AddProyecto(Proyecto newProyecto)
        {
            Proyectos.Add(newProyecto);
        }

        public void AddUsuario(Usuario newUsuario)
        {
            Usuarios.Add(newUsuario);
        }

        public bool DeleteDocente(Docente oldDocente)
        {
            return Docentes.Remove(oldDocente);
        }

        public bool DeleteFuncionario(FuncionarioDesarollo oldFuncionarioDesarollo)
        {
            return Funcionarios.Remove(oldFuncionarioDesarollo);
        }

        public bool DeleteParEvaluador(ParEvaluador oldParEvaluador)
        {
            return Pares.Remove(oldParEvaluador);
        }

        public bool DeleteProyecto(Proyecto oldProyecto)
        {
            return Proyectos.Remove(oldProyecto);
        }

        public bool DeleteUsuario(Usuario oldUsuario)
        {
            return Usuarios.Remove(oldUsuario);
        }

        public bool UpdateDocente(Docente oldDocente, Docente newDocente)
        {
            if (DeleteDocente(oldDocente))
            {
                AddDocente(newDocente);
                return true;
            }
            return false;
        }

        public bool UpdateFuncionario(FuncionarioDesarollo oldFuncionarioDesarollo, FuncionarioDesarollo newFuncionarioDesarollo)
        {
            if (DeleteFuncionario(oldFuncionarioDesarollo))
            {
                AddFuncionario(newFuncionarioDesarollo);
                return true;
            }
            return false;
        }

        public bool UpdateParEvaluador(ParEvaluador oldParEvaluador, ParEvaluador newParEvaluador)
        {
            if (DeleteParEvaluador(oldParEvaluador))
            {
                AddParEvaluador(newParEvaluador);
                return true;
            }
            return false;
        }

        public bool UpdateProyecto(Proyecto oldProyecto, Proyecto newProyecto)
        {
            if (DeleteProyecto(oldProyecto))
            {
                AddProyecto(newProyecto);
                return true;
            }
            return false;
        }

        public bool UpdateUsuario(Usuario oldUsuario, Usuario newUsuario)
        {
            if (DeleteUsuario(oldUsuario))
            {
                AddUsuario(newUsuario);
                return true;
            }
            return false;
        }
    }
}
