using CarreandoDIS.Areas.Administrador.Data;
using CarreandoDIS.Areas.Cliente.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarreandoDIS.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class ReseniaController : Controller
    {
        //[Authorize(Roles = "C")]
        [HttpGet("/Cliente/Resenia/Index")]
        public async Task<IActionResult> Index()
        {

            var reseniaDA = new ReseniaDA();

            var clienteDA = new ClienteDA();

            var clientes=clienteDA.GetClienteReseniaVMs();

            foreach (var cli in clientes)
            {
                var resenia = reseniaDA.GetReseniaxUsuario(cli.idUsuario);

                if (resenia != null)
                {
                    cli.calificacion = resenia.calificacion;
                    cli.fechaPublicacion = resenia.fechaPublicacion;
                    cli.contenido = resenia.contenido;
                }
                
            }


            return View(clientes);
        }

    }
}
