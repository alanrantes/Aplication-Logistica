using LogisticaApp.Api.Data;
using LogisticaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LogisticaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarrosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarrosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/carros
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var carros = await _context.Carros.ToListAsync();
            return Ok(carros);
        }

        // POST: api/carros
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Carro carro)
        {
            _context.Carros.Add(carro);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), carro);
        }
    }
}
