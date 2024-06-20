using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Cliente.Data
{
    public class ReseniaDA
    {
        public IEnumerable<Resenia> GetResenias()
        {
            using (var db = new ApplicationDbContext())
            {
                var listado = db.Resenia.ToList();
                return listado;
            }
        }
    }
}
