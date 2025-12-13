using LogisticaApp.Api.Data;
using LogisticaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LogisticaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class VeiculosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VeiculosController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var veiculos = await _context.Veiculos.ToListAsync();
            return Ok(veiculos);
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Veiculo veiculo)
        {
            _context.Veiculos.Add(veiculo);
            await _context.SaveChangesAsync();
            return Ok(veiculo);
        }
    }
}
