using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudianteId { get; set; }
        public string Nombres { get; set; }
        public string Matricula { get; set; }
        public int Balance { get; set; }

        public Estudiantes()
        {
            EstudianteId = 0;
            Nombres = string.Empty;
            Matricula = string.Empty;
            Balance = 0;
        }

      
    }
}
