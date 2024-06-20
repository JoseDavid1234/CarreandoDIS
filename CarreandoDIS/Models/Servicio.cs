using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Servicio
    {

        [Key]
        public int IdServicio { get; set; }

        public DateTime? PeriodoFacturacion { get; set; }

        public string? Estado { get; set; }

        public int? FkPlan { get; set; }

        public DateTime? FechaActivacion { get; set; }

    }
}
