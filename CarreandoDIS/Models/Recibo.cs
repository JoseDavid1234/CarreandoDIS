using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Recibo
    {

        [Key]
        public int IdUsuario { get; set; }

        public string? NombreUsuario { get; set; }

        public string? ContraseniaUsuario { get; set; }

        public string? RolUsuario { get; set; }

        public string? CorreoUsuario { get; set; }

        public string? ApellidoPaterno { get; set; }

        public string? ApellidoMaterno { get; set; }

        public string? DniUsuario { get; set; }

        public string? SexoUsuario { get; set; }

        public int? FkServicio { get; set; }

        public int? FkPromocion { get; set; }

    }
}
