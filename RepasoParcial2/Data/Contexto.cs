using Microsoft.EntityFrameworkCore;
using RepasoParcial2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial2.Data
{
    public class Contexto : DbContext
    {
        public DbSet<Inscripcion> Inscripcion { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }
        public DbSet<Asignaturas> Asignaturas { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"Data Source= Database/repasoParcial.db");
        }
    }
}
