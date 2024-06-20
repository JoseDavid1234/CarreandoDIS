using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Administrador.Data
{
    public class ReciboDA
    {

        public IEnumerable<Recibo> GetRecibos()
        {
            var listado = new List<Recibo>();
            using (var db = new ApplicationDbContext())
            {
                //listado = db.Cliente.OrderBy(x => x.NombreTipoPersona).ToList();
                listado = db.Recibo.ToList();
            }
            return listado;
        }



    }
}
