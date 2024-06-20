using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Resenia
    {

        [Key]
        public int IdResenia { get; set; }

        public string? Contenido { get; set; }

        public int? Calificacion { get; set; }

        public DateTime? FechaPublicacion { get; set; }

        public string? FkUsuario { get; set; }

        public string? FkPlan { get; set; }

    }
}
