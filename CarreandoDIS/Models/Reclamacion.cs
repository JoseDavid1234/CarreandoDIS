using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Reclamacion
    {

        [Key]
        public int IdReclamacion { get; set; }

        public string? Contenido { get; set; }

        public string? TipoReclamacion { get; set; }

        public DateTime? FechaPublicacion { get; set; }

        public int? FkUsuario { get; set; }

    }
}
