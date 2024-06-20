using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Administrador.Data
{
    public class TicketDA
    {

        public IEnumerable<Ticket> GetTickets()
        {
            var listado = new List<Ticket>();
            using (var db = new ApplicationDbContext())
            {
                //listado = db.Cliente.OrderBy(x => x.NombreTipoPersona).ToList();
                listado = db.Ticket.ToList();
            }
            return listado;
        }

        public IEnumerable<Ticket> GetTicketsHechos()
        {
            var listado = new List<Ticket>();
            using (var db = new ApplicationDbContext())
            {
                //listado = db.Cliente.OrderBy(x => x.NombreTipoPersona).ToList();
                listado = db.Ticket.Where(x => x.estado == "REALIZADO").ToList();
            }
            return listado;
        }

    }
}
