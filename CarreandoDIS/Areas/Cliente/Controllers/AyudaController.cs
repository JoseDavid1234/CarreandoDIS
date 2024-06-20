using CarreandoDIS.Areas.Cliente.Data;
using CarreandoDIS.Areas.Cliente.Models;
using CarreandoDIS.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CarreandoDIS.Areas.Cliente.Controllers
{
    [Area("Cliente")]
    public class AyudaController : Controller
    {

        public readonly string cadenaSQL; // PARA OBTENER LA CADENA DE CONEXION  DE LA BD
        private readonly IHttpContextAccessor _httpContextAccessor; // Para acceder a los datos del usuario conectado

        public AyudaController(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            cadenaSQL = config.GetConnectionString("DefaultConnection"); // PARA OBTENER LA CADENA DE CONEXION DE LA BD
            _httpContextAccessor = httpContextAccessor; // Para acceder a los datos del usuario conectado
        }



        // GET: AyudaController
        //[Authorize(Roles = "C")]
        [HttpGet("/Cliente/Ayuda/SolicitarAyudaTecnica")]
        public async Task<IActionResult> SolicitarAyudaTecnica(int usuarioId)
        {

            var ticketDA = new AyudaDA();

            var usuario = ticketDA.GetUsuarioById(usuarioId); // Método para obtener el usuario por su ID
            ViewBag.Usuario = usuario;
            var tickets = ticketDA.GetTicketsPorUsuario(usuarioId);
            
            return View("SolicitarAyudaTecnica", tickets);
        }

        // GET: AyudaController
        //[Authorize(Roles = "C")]
        [HttpPost("CrearTicket")]
        public async Task<IActionResult> CrearTicket(Ticket ticket,int usuarioId)
        {

            var ticketDA = new AyudaDA();
            ticket.fkCliente = usuarioId;
            ticket.estado = "PENDIENTE";
            ticket.fechaEmision = DateTime.Now;
            var usuario = ticketDA.GetUsuarioById(usuarioId);
            var tickets = ticketDA.PostCrearTicket(ticket);
            return RedirectToAction("Index", new { usuarioId = usuarioId });


        }

        [HttpGet("/Cliente/Ayuda/Cobertura")]
        public async Task<IActionResult> Cobertura(int usuarioId)
        {

            return View();
        }


    }
}
