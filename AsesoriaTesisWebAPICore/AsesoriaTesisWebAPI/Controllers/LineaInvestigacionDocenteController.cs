using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsesoriaTesisWebAPI.Models;

namespace AsesoriaTesisWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LineaInvestigacionDocenteController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public LineaInvestigacionDocenteController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/LineaInvestigacionDocente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LineaInvestigacionDocente>>> GetLineaInvestigacionDocente()
        {
            return await _context.LineaInvestigacionDocente.ToListAsync();
        }

        // GET: api/LineaInvestigacionDocente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LineaInvestigacionDocente>> GetLineaInvestigacionDocente(int id)
        {
            var lineaInvestigacionDocente = await _context.LineaInvestigacionDocente.FindAsync(id);

            if (lineaInvestigacionDocente == null)
            {
                return NotFound();
            }

            return lineaInvestigacionDocente;
        }

        // PUT: api/LineaInvestigacionDocente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLineaInvestigacionDocente(int id, LineaInvestigacionDocente lineaInvestigacionDocente)
        {
            if (id != lineaInvestigacionDocente.LineaInvestigacionDocenteId)
            {
                return BadRequest();
            }

            _context.Entry(lineaInvestigacionDocente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineaInvestigacionDocenteExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/LineaInvestigacionDocente
        [HttpPost]
        public async Task<ActionResult<LineaInvestigacionDocente>> PostLineaInvestigacionDocente(LineaInvestigacionDocente lineaInvestigacionDocente)
        {
            _context.LineaInvestigacionDocente.Add(lineaInvestigacionDocente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLineaInvestigacionDocente", new { id = lineaInvestigacionDocente.LineaInvestigacionDocenteId }, lineaInvestigacionDocente);
        }

        // DELETE: api/LineaInvestigacionDocente/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LineaInvestigacionDocente>> DeleteLineaInvestigacionDocente(int id)
        {
            var lineaInvestigacionDocente = await _context.LineaInvestigacionDocente.FindAsync(id);
            if (lineaInvestigacionDocente == null)
            {
                return NotFound();
            }

            _context.LineaInvestigacionDocente.Remove(lineaInvestigacionDocente);
            await _context.SaveChangesAsync();

            return lineaInvestigacionDocente;
        }

        private bool LineaInvestigacionDocenteExists(int id)
        {
            return _context.LineaInvestigacionDocente.Any(e => e.LineaInvestigacionDocenteId == id);
        }
    }
}
