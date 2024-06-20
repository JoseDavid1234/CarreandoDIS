using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Administrador.Data
{
    public class PromocionDA
    {

        public IEnumerable<Usuario> GetClientes()
        {
            var listado = new List<Usuario>();
            using (var db = new ApplicationDbContext())
            {

                listado = db.Usuario.ToList();
            }
            return listado;
        }

        public void CrearPromocion(Promocion promocion)
        {
            using (var db = new ApplicationDbContext())
            {
                db.Promocion.Add(promocion);
                db.SaveChanges();
            }
        }

    }
}
