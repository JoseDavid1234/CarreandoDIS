﻿using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Recibo
    {

        [Key]
        public int idRecibo { get; set; }

        public string? plan { get; set; }

        public decimal? monto { get; set; }

        public string? estado { get; set; }

        public int? fkUsuario { get; set; }

        public DateTime? fechaVencimiento { get; set; }

        public DateTime? fechaPago { get; set; }

    }
}
