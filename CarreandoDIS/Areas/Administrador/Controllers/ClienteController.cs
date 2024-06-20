using CarreandoDIS.Areas.Administrador.Data;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;


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

        [HttpGet("/Administrador/Cliente/ListaClientes")]
        public async Task<IActionResult> ListaClientes()
        {
            var clienteDA = new ClienteDA();

            var clientes = clienteDA.GetClientes();

            return View("ListaClientes", clientes);
        }

        [HttpGet("BuscarClientes")]
        public async Task<IActionResult> BuscarClientes(string cadenaBusqueda)
        {
            Debug.WriteLine($"La cadena de búsqueda es: {cadenaBusqueda}");
            Console.WriteLine($"Se depuro {cadenaBusqueda}");
            var clienteDA = new TecnicoDA();
            var clientes = clienteDA.GetClientesPorTexto(cadenaBusqueda);
            return View("ListaClientes", clientes);
        }




    }
}
