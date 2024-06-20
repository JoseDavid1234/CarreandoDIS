using CarreandoDIS.Models;

namespace CarreandoDIS.Areas.Administrador.Data
{
    public class ClienteDA
    {

        public IEnumerable<Usuario> GetClientes()
        {
            var listado = new List<Usuario>();
            using (var db = new ApplicationDbContext())
            {
                //listado = db.Cliente.OrderBy(x => x.NombreTipoPersona).ToList();
                listado = db.Usuario.ToList();
            }
            return listado;
        }

    }
}
