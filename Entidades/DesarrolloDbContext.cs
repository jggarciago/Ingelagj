using Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistencia
{

    public class DesarrolloDbContext : DbContext, Contexto


    {
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<FuncionarioDesarollo> Funcionarios { get; set; }
        public DbSet<ParEvaluador> Pares { get; set; }
        public DbSet<Proyecto> Proyectos { get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Asignacion> asignaciones { get; set; }

        public void AddAsignacion(Asignacion newAsignacion)
        {
            throw new NotImplementedException();
        }

        public void AddDocente(Docente newDocente)
        {
            throw new NotImplementedException();
        }

        public void AddFuncionario(FuncionarioDesarollo newFuncionario)
        {
            throw new NotImplementedException();
        }

        public void AddParEvaluador(ParEvaluador newParEvaluador)
        {
            throw new NotImplementedException();
        }

        public void AddProyecto(Proyecto newProyecto)
        {
            throw new NotImplementedException();
        }

        public void AddUsuario(Usuario newUsuario)
        {
            throw new NotImplementedException();
        }

        public bool DeleteAsignacion(Asignacion oldAsignacion)
        {
            throw new NotImplementedException();
        }

        public bool DeleteDocente(Docente oldDocente)
        {
            throw new NotImplementedException();
        }

        public bool DeleteFuncionario(FuncionarioDesarollo oldFuncionarioDesarollo)
        {
            throw new NotImplementedException();
        }

        public bool DeleteParEvaluador(ParEvaluador oldParEvaluador)
        {
            throw new NotImplementedException();
        }

        public bool DeleteProyecto(Proyecto oldProyecto)
        {
            throw new NotImplementedException();
        }

        public bool DeleteUsuario(Usuario oldUsuario)
        {
            throw new NotImplementedException();
        }

        public bool UpdateAsignacion(Asignacion oldAsignacion, Asignacion newAsignacion)
        {
            throw new NotImplementedException();
        }

        public bool UpdateDocente(Docente oldDocente, Docente newDocente)
        {
            throw new NotImplementedException();
        }

        public bool UpdateFuncionario(FuncionarioDesarollo oldFuncionarioDesarollo, FuncionarioDesarollo newFuncionarioDesarollo)
        {
            throw new NotImplementedException();
        }

        public bool UpdateParEvaluador(ParEvaluador oldParEvaluador, ParEvaluador newParEvaluador)
        {
            throw new NotImplementedException();
        }

        public bool UpdateProyecto(Proyecto oldProyecto, Proyecto newProyecto)
        {
            throw new NotImplementedException();
        }

        public bool UpdateUsuario(Usuario oldUsuario, Usuario newUsuario)
        {
            throw new NotImplementedException();
        }
    }
}
