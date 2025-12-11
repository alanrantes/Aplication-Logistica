using LogisticaApp.Models;
using Microsoft.AspNetCore.Mvc;

namespace LogisticaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculosController : ControllerBase
    {
        // Lista temporária em memória
        private static List<Veiculo> veiculos = new List<Veiculo>();

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(veiculos);
        }

        [HttpPost]
        public IActionResult Post([FromBody] Veiculo veiculo)
        {
            veiculos.Add(veiculo);
            return Ok(veiculo);
        }
    }
}
