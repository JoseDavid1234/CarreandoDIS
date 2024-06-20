using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Plan
    {

        [Key]
        public int IdPlan { get; set; }

        public decimal? Precio { get; set; }

        public string? Nombre { get; set; }

        public int? Velocidad { get; set; }

        public string? Descripcion { get; set; }

    }
}
