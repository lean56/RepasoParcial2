using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial.Models
{
    public class InscripcionDetalles
    {
        [Key]
        public int InscripcionDetalleId { get; set; }
        public int InscripcionId { get; set; }
        public int AsignaturaId { get; set; }
        public string DescripcionAsignatura { get; set; }
        public int Creditos { get; set; }
        public int Subtotal { get; set; }

        public InscripcionDetalles()
        {
            InscripcionDetalleId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            DescripcionAsignatura = string.Empty;
            Creditos = 0;
            Subtotal = 0;
        }
    }
}
