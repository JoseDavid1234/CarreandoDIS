﻿using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Resenia
    {

        [Key]
        public int idResenia { get; set; }

        public string? contenido { get; set; }

        public int? calificacion { get; set; }

        public DateTime? fechaPublicacion { get; set; }

        public int? fkUsuario { get; set; }

        public int? fkPlan { get; set; }

    }
}
