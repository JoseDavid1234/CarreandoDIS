using CarreandoDIS.Areas.Administrador.Data;
using Microsoft.AspNetCore.Mvc;

namespace CarreandoDIS.Areas.Administrador.Controllers
{
    [Area("Administrador")]
    public class ClienteController: Controller
    {

        public readonly string cadenaSQL; // PARA OBTENER LA CADENA DE CONEXION  DE LA BD
        private readonly IHttpContextAccessor _httpContextAccessor; // Para acceder a los datos del usuario conectado

        public ClienteController(IConfiguration config, IHttpContextAccessor httpContextAccessor)
        {
            cadenaSQL = config.GetConnectionString("DefaultConnection"); // PARA OBTENER LA CADENA DE CONEXION DE LA BD
            _httpContextAccessor = httpContextAccessor; // Para acceder a los datos del usuario conectado
        }

        [HttpGet("ListaClientes")]
        public async Task<IActionResult> ListaClientes()
        {
            var clienteDA = new ClienteDA();

            var clientes = clienteDA.GetClientes();

            return View("ListaClientes", clientes);
        }
    }
}
