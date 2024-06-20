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

        public Resenia GetReseniaxUsuario(int fkUsuario)
        {

            var resenia = new Resenia();
            using (var db = new ApplicationDbContext())
            {
                var listado = db.Resenia.Where(x => x.fkUsuario == fkUsuario).ToList();

                resenia = listado.FirstOrDefault();
            }
            return resenia;

        }
    }
}
