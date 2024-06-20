using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Plan
    {

        [Key]
        public int idPlan { get; set; }

        public decimal? precio { get; set; }

        public string? nombre { get; set; }

        public int? velocidad { get; set; }

        public string? descripcion { get; set; }

    }
}
