﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial2.Models
{
    public class InscripcionDetalles
    {
        [Key]
        public int InscripcionDetalleId { get; set; }
        [Required]
        public int InscripcionId { get; set; }
        [Required]

        public int AsignaturaId { get; set; }
        [Required]

        public string DescripcionAsignatura { get; set; }
        [Required]

        public int Creditos { get; set; }
        [Required]

        public int Subtotal { get; set; }

        public InscripcionDetalles()
        {
            InscripcionDetalleId = 0;
            InscripcionId = 0;
            AsignaturaId = 0;
            Subtotal = 0;
            Creditos = 0;
        }
        public InscripcionDetalles(int inscripcionDetalleId, int inscripcionId, int asignaturaId, int subTotal)
        {
            InscripcionDetalleId = inscripcionDetalleId;
            InscripcionId = inscripcionId;
            AsignaturaId = asignaturaId;
            Subtotal = subTotal;
        }
    }
}
