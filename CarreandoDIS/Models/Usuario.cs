using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Usuario
    {

        [Key]
        public int IdUsuario { get; set; }

        public string? Nombre { get; set; }

        public string? Contrasenia { get; set; }

        public string? Rol { get; set; }

        public string? Correo { get; set; }

        public string? ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public string? Dni { get; set; }

        public string? Sexo { get; set; }

        public int? FkServicio { get; set; }

        public int? FkPromocion { get; set; }

    }
}
