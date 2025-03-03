using FirstCodeAproachOneToMany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion.Internal;
using System.Reflection.Metadata.Ecma335;

namespace FirstCodeAproachOneToMany.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClaseController : ControllerBase
    {
        private readonly ScoalaDbContext _context;

        public ClaseController(ScoalaDbContext context)
        {
            _context = context;
        }

        [HttpGet]

        public async Task<ActionResult<List<Clasa>>> GetClasa()
        {
            var clase = await _context.Clase.Include(c => c.NrElevi).ToListAsync();
            return Ok(clase);   
        }

        [HttpDelete("ClasaId/{id}/ElevId/{id-elev}")]

        public async Task<ActionResult> DeleteClasa(int clasaid, int elevid)
        {
            var clasa = await _context.Clase.Include(e => e.Elevi)
                                               .FirstOrDefaultAsync(c => c.ClasaID == clasaid);

            if (clasa == null)
                return NotFound();

            var elev = clasa.Elevi.FirstOrDefault(e => e.ElevID == elevid);

            if (elev == null)
                return NotFound();

            _context.Clase.Remove(clasa);
            await _context.SaveChangesAsync();

            return NoContent();
        }
    }
}
