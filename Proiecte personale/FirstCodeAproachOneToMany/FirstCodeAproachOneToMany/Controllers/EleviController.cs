using FirstCodeAproachOneToMany.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.Extensions.FileProviders;

namespace FirstCodeAproachOneToMany.Controllers
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

        public async Task<ActionResult<List<Elev>>> GetElevi()
        {   
            var elev = await _context.Elevi.ToListAsync();
            return elev;
        }

        [HttpGet("{id}")]

        public async Task<ActionResult<Elev>> GetElevByID(int id)
        {
            var elev = await _context.Elevi.FindAsync(id);

            if (elev == null)
                return NotFound();

            return Ok();
        }

        [HttpPost]
        public async Task<ActionResult<Elev>> Postelev(Elev elev)
        {   
            _context.Elevi.Add(elev);
            await _context.SaveChangesAsync();

            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Elev>> DeleteElev(int id)
        {
            var elev = await _context.Elevi.FindAsync(id);

            if (elev == null)
                return NotFound();

            _context.Elevi.Remove(elev);
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

        private bool ExistaElev(int id)
        {
            return _context.Elevi.Any(e => e.ElevID == id);
        }

        [HttpGet("filtru")]

        public async Task<ActionResult<Elev>> GetByFiltru([FromQuery] string text, [FromQuery] string sortBy)
        {
            var elev = await _context.Elevi.ToListAsync();

            var stud = elev.Where(e => e.ElevNume.Contains(text, StringComparison.OrdinalIgnoreCase));

            switch (sortBy)
            {
                case "nume":
                    stud = stud.OrderBy(e => e.ElevNume);
                    break;

                case "id":
                    stud = stud.OrderBy(e => e.ElevID);
                    break;

                case "data":
                    stud = stud.OrderByDescending(e => e.DataNasterii);
                    break;

                case "clasa":
                    stud = stud.OrderBy(c => c.ClasaID);
                    break;

                default: 
                    return NotFound();
            }
            return Ok(stud);
        }
    }
}
