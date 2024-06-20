using CarreandoDIS.Models;
using System.Diagnostics;

namespace CarreandoDIS.Areas.Cliente.Data
{
    public class PlanesDA
    {

        public IEnumerable<Plan> GetPlanes()
        {
            
            var listadoPlanes = new List<Plan>();
            using (var db = new ApplicationDbContext())
            {
                
                //listado = db.Cliente.OrderBy(x => x.NombreTipoPersona).ToList();
                listadoPlanes = db.Plan.ToList();
                
                return listadoPlanes;
            }
        }

        



    }
}
