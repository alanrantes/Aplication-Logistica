using LogisticaApp.Api.Data;
using LogisticaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LogisticaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class MotosController : ControllerBase
    {
        private readonly AppDbContext _context;

        public MotosController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/motos
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var motos = await _context.Motos.ToListAsync();
            return Ok(motos);
        }

        // POST: api/motos
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Moto moto)
        {
            _context.Motos.Add(moto);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), moto);
        }
    }
}
