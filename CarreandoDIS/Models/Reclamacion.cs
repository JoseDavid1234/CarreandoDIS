using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Reclamacion
    {

        [Key]
        public int idReclamacion { get; set; }

        public string? contenido { get; set; }

        public string? tipoReclamacion { get; set; }

        public DateTime? fechaPublicacion { get; set; }

        public int? fkUsuario { get; set; }

    }
}
