using Gestproject.API.Data;
using Gestproject.Shared.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Gestproject.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly DataContext _context;

        public ProjectsController(DataContext context)
        {
            _context = context;
        }

        // Get con lista
        [HttpGet]
        public async Task<ActionResult> Get()
        {
            return Ok(await _context.Projects.ToListAsync());
        }

        // Get con parametro
        [HttpGet("{id:int}")]
        public async Task<ActionResult> Get(int id)
        {
            var project = await _context.Projects.FirstOrDefaultAsync(x=>x.Id ==id);
                
            if (project == null) 
            { 
                return NotFound();
            }

            return Ok(project);
        }

        // Insertar un registro
        [HttpPost]
        public async Task<ActionResult> Post(Project project)
        {
            _context.Add(project);
            await _context.SaveChangesAsync();
            return Ok(project);
        }
    }
}
