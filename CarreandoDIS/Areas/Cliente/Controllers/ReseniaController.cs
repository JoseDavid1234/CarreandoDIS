using CarreandoDIS.Areas.Cliente.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarreandoDIS.Areas.Cliente.Controllers
{
    public class ReseniaController : Controller
    {
        // GET: ReseniaController
        public ActionResult Index()
        {
            return View();
        }

        //[Authorize(Roles = "C")]
        [HttpGet("Reseñas")]
        public async Task<IActionResult> Reseñas()
        {
            var resenias = new ReseniasDA();
            var listaResenias = resenias.GetResenias();
            return View("Reseñas", resenias);
        }

    }
}
