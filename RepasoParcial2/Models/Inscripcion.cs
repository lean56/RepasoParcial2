﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace RepasoParcial2.Models
{
    public class Inscripcion
    {
        [Key]
        public int InscripcionId { get; set; }
        public int EstudianteId { get; set; }
        public string  Semestre { get; set; }
        public int Limite { get; set; }
        public int Tomados { get; set; }
        public int Disponible { get; set; }
        public int Monto { get; set; }

        [ForeignKey("InscripcionId")]
        public List<InscripcionDetalles>Detalles { get; set; }
        public Inscripcion()
        {
            InscripcionId = 0;
            EstudianteId = 0;
            Semestre = string.Empty;
            Limite = 0;
            Tomados = 0;
            Disponible = 0;
            Monto = 0;
            Detalles = new List<InscripcionDetalles>();
        }
    }
}
