using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Servicio
    {

        [Key]
        public int idServicio { get; set; }

        public DateTime? periodoFacturacion { get; set; }

        public string? estado { get; set; }

        public int? fkPlan { get; set; }

        public DateTime? fechaActivacion { get; set; }

    }
}
