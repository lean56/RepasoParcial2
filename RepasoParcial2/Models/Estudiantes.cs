using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial2.Models
{
    public class Estudiantes
    {
        [Key]
        public int EstudiantesId { get; set; }
        public string Nombres { get; set; }
        public string Matricula { get; set; }
        public int Deuda { get; set; }

        public Estudiantes()
        {
            EstudiantesId = 0;
            Nombres = string.Empty;
            Matricula = string.Empty; 
            Deuda = 0;
        }
    }
}
