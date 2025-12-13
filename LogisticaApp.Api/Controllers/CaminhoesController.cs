using LogisticaApp.Api.Data;
using LogisticaApp.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace LogisticaApp.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CaminhoesController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CaminhoesController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/caminhoes
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var caminhoes = await _context.Caminhoes.ToListAsync();
            return Ok(caminhoes);
        }

        // POST: api/caminhoes
        [HttpPost]
        public async Task<IActionResult> Post([FromBody] Caminhao caminhao)
        {
            _context.Caminhoes.Add(caminhao);
            await _context.SaveChangesAsync();
            return CreatedAtAction(nameof(Get), caminhao);
        }
    }
}
