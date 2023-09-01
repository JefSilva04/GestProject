using Gestproject.API.Data;
using Gestproject.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestproject.API.Controllers
{
    [ApiController]
    [Route("api/investigadors")]
    public class InvestigadorController : ControllerBase
    {
        private readonly DataContext _context;

        public InvestigadorController(DataContext context)
        {
            _context = context;
        }

        // Get con lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Investigadors.ToListAsync());
        }

        // Get con parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var investigador = await _context.Investigadors.FirstOrDefaultAsync(x=>x.Id ==id);
                
            if (investigador == null) 
            { 
                return NotFound();
            }

            return Ok(investigador);
        }

        // Insertar un registro
        [HttpPost]
        public async Task<ActionResult> Post(Investigador investigador)
        {
            _context.Add(investigador);
            await _context.SaveChangesAsync();
            return Ok(investigador);
        }
    }
}