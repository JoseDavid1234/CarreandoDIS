using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Promocion
    {

        [Key]
        public int IdRecibo { get; set; }

        public string? Plan { get; set; }

        public int? Monto { get; set; }

        public string? Estado { get; set; }

        public int? FkUsuario { get; set; }

        public DateTime? FechaVencimiento { get; set; }

        public DateTime? FechaPago { get; set; }

    }
}
