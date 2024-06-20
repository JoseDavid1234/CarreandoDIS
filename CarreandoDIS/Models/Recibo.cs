using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Recibo
    {

        [Key]
        public int idUsuario { get; set; }

        public string? nombreUsuario { get; set; }

        public string? contraseniaUsuario { get; set; }

        public string? rolUsuario { get; set; }

        public string? correoUsuario { get; set; }

        public string? apellidoPaterno { get; set; }

        public string? apellidoMaterno { get; set; }

        public string? dniUsuario { get; set; }

        public string? sexoUsuario { get; set; }

        public int? fkServicio { get; set; }

        public int? fkPromocion { get; set; }

    }
}
