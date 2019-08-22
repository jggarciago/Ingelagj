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
    }
}
