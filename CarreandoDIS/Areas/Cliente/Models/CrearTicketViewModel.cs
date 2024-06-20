using CarreandoDIS.Models;

namespace CarreandoDIS.Areas.Cliente.Models
{
    public class CrearTicketViewModel
    {
        public Usuario Usuario { get; set; }
        public List<Ticket> Ticket { get; set; }
    }
}
