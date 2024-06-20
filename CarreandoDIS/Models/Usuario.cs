using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Usuario
    {

        [Key]
        public int idUsuario { get; set; }

        public string? nombre { get; set; }

        public string? contrasenia { get; set; }

        public string? rol { get; set; }

        public string? correo { get; set; }

        public string? apellidoPaterno { get; set; }

        public string? apellidoMaterno { get; set; }

        public string? dni { get; set; }

        public string? sexo { get; set; }

        public int? fkServicio { get; set; }

        public int? fkPromocion { get; set; }

    }
}
