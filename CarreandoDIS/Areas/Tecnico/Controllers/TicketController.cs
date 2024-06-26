﻿using CarreandoDIS.Areas.Administrador.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarreandoDIS.Areas.Tecnico.Controllers
{
    [Area("Tecnico")]
    public class TicketController : Controller
    {

        // GET: TicketController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TicketController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TicketController/Create
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

        // GET: TicketController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TicketController/Edit/5
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

        // GET: TicketController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TicketController/Delete/5
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


        [HttpGet("/Tecnico/Ticket/Index")]
        public IActionResult Index()
        {

            var ticketDA = new TicketDA();

            var tickets = ticketDA.GetTickets();
            return View("Index", tickets);
        }

        [HttpGet("/Tecnico/Ticket/TareasHechas")]
        public IActionResult TareasHechas()
        {

            var ticketDA = new TicketDA();

            var tickets = ticketDA.GetTicketsHechos();
            return View("TareasHechas", tickets);
        }

    }
}
