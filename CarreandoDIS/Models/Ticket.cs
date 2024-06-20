using System.ComponentModel.DataAnnotations;

namespace CarreandoDIS.Models
{
    public class Ticket
    {

        [Key]
        public int idTicket { get; set; }

        public string? tipoProblematica { get; set; }

        public string? descripcion { get; set; }

        public string? estado { get; set; }

        public DateTime? fechaEmision { get; set; }

        public int? fkTecnico { get; set; }

        public int? fkCliente { get; set; }

    }
}
