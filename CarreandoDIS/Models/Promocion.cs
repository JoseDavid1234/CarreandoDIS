using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Promocion
    {

        [Key]
        public int idPromocion { get; set; }

        public string? nombre { get; set; }

        public int? efectoPromocion { get; set; }

        public string? urlImagen { get; set; }

    }
}
