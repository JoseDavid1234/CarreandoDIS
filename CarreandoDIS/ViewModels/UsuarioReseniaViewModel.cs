using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.ViewModels
{
    public class UsuarioReseniaVM
    {

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

        public int? calificacion { get; set; }

        public string? contenido { get; set; }

        public DateTime? fechaPublicacion { get; set; }

    }
}
