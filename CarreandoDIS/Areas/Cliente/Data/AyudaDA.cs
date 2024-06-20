using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Cliente.Data
{
    public class AyudaDA
    {

        public IEnumerable<Ticket> GetTicketsPorUsuario(int idUsuario)
        {
            using (var db = new ApplicationDbContext())
            {
                var listado = db.Ticket
                                .Where(t => t.fkCliente == idUsuario)
                                .ToList();
                return listado;
            }
        }


        public Ticket PostCrearTicket(Ticket ticket)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Ticket.Add(ticket);
                db.SaveChanges();
            }

            return ticket;
        }

        public Usuario GetUsuarioById(int idUsuario)
        {
            using (var db = new ApplicationDbContext())
            {
                var usuario = db.Usuario
                                .Where(t => t.idUsuario == idUsuario)
                                .First();
                //return usuario;
                return usuario;
            }

        }

    }
}
