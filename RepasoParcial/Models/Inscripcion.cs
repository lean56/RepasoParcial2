﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial.Models
{
    public class Inscripcion
    {
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public string Semestre { get; set; }
        [Required]
        public int Limite { get; set; }
        [Required]

        public int Tomados { get; set; }
        [Required]

        public int Disponible { get; set; }
        [Required]

        public DateTime Fecha { get; set; }
        public int Monto { get; set; }

        [ForeignKey("InscripcionId")]
        public List<InscripcionDetalles> Detalles { get; set; }

        public Inscripcion()
        {
            InscripcionId = 0;
            EstudianteId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
            Fecha = DateTime.Now;
            Monto = 0;
            Detalles = new List<InscripcionDetalles>();
        }
    }
}
