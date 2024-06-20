using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Cliente.Data
{
    public class ReseniasDA
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
