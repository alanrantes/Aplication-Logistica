using Microsoft.AspNetCore.Mvc;
using LogisticaApp.Models;

namespace LogisticaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ClientesController : ControllerBase
    {
        private static List<Cliente> clientes = new();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(clientes);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Cliente cliente)
        {
            clientes.Add(cliente);
            return Created("", cliente);
        }
    }
}
