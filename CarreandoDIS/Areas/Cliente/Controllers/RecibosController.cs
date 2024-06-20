using CarreandoDIS.Areas.Administrador.Data;
using CarreandoDIS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarreandoDIS.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class RecibosController : Controller
    {
        // GET: RecibosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RecibosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RecibosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecibosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RecibosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RecibosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RecibosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [HttpGet("/Cliente/Recibos/Index")]
        public async Task<IActionResult> Index()
        {
            //var idUserClaim = User.FindFirst("idUser").Value;

            var idUserClaim = "1";
            var reciboDA = new ReciboDA();

            if (idUserClaim != null)
            {
                int idCliente = int.Parse(idUserClaim);

                var recibos = reciboDA.GetRecibos();

                return View("Index", recibos);

            }
            else
            {
                return View("Error");
            }
        }
    }
}
