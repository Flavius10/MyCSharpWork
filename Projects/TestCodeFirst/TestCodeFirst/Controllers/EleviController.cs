using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.Identity.Client;
using TestCodeFirst.Models;

namespace TestCodeFirst.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class EleviController : ControllerBase
    {
        private readonly ScoalaDbContext _context;

        public EleviController(ScoalaDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Elev>>> GetElev()
        {
            var elev = await _context.Elevi.ToListAsync();

            return Ok(elev);
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Elev>> GetElevById(int id)
        {
            var elev = await _context.Elevi.FindAsync(id);

            if (elev == null)
                return NotFound();

            return Ok(elev);
        }

        [HttpPost]

        public async Task<ActionResult<Elev>> PostElev(Elev elev)
        {
            _context.Elevi.Add(elev);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        [HttpPut("{id}")]

        public async Task<ActionResult<Elev>> PutElev(int id, Elev elev)
        {
            if(id != elev.ElevID)
                return BadRequest();

            if (!ExistaElev(id))
                return NotFound();

            _context.Entry(elev).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return NoContent();
        }

        bool ExistaElev(int id)
        {
            return _context.Elevi.Any(e => e.ElevID == id);
        }

        [HttpDelete("{id}")]
    
        public async Task<ActionResult<Elev>> DeleteElev(int id)
        {
            var elev = await _context.Elevi.FindAsync(id);

            if(elev == null) return NotFound();

            _context.Elevi.Remove(elev);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
