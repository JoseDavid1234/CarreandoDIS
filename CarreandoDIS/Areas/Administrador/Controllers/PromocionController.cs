using CarreandoDIS.Areas.Administrador.Data;
using Microsoft.AspNetCore.Mvc;
using CarreandoDIS.Models;
using System.Diagnostics;


namespace CarreandoDIS.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class PromocionController: Controller
    {

        public readonly string cadenaSQL; // PARA OBTENER LA CADENA DE CONEXION  DE LA BD
        private readonly IHttpContextAccessor _httpContextAccessor; // Para acceder a los datos del usuario conectado

        public PromocionController(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            cadenaSQL = config.GetConnectionString("DefaultConnection"); // PARA OBTENER LA CADENA DE CONEXION DE LA BD
            _httpContextAccessor = httpContextAccessor; // Para acceder a los datos del usuario conectado
        }

        [HttpPost("CrearPromocion")]
        public async Task<IActionResult> CrearPromocion(Promocion promocion)
        {
            var promocionDA = new PromocionDA();
            promocionDA.CrearPromocion(promocion);

            return Ok();
        }

        [HttpGet("CrearPromocionIndex")]
        public async Task<IActionResult> CrearPromocionIndex()
        {
            //var promocionDA = new PromocionDA();
            //promocionDA.CrearPromocion(promocion);

            return View("PromocionIndex");
        }


    }
}
