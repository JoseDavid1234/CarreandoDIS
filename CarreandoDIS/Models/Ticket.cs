using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Ticket
    {

        [Key]
        public int IdTicket { get; set; }

        public string? TipoProblematica { get; set; }

        public string? Descripcion { get; set; }

        public string? Estado { get; set; }

        public DateTime? FechaEmision { get; set; }

        public int? FkTecnico { get; set; }

        public int? FkCliente { get; set; }

    }
}
