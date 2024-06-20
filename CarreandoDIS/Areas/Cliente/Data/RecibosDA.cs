using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Administrador.Data
{
    public class PlanesDA
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

        public IEnumerable<Usuario> GetClientesPorTexto(string cadenaBusqueda)
        {
            var listado = new List<Usuario>();
            using (var db = new ApplicationDbContext())
            {
                if (string.IsNullOrWhiteSpace(cadenaBusqueda))
                {
                    listado = db.Usuario.ToList();
                }
                else
                {
                    listado = db.Usuario
                                .Where(u => u.nombre.Contains(cadenaBusqueda) ||
                                            u.apellidoPaterno.Contains(cadenaBusqueda) ||
                                            u.apellidoMaterno.Contains(cadenaBusqueda))
                                .ToList();
                    Debug.WriteLine("Se hizo un log aqui");
                }
            }

            

            return listado;
        }



    }
}
