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
    public class LineaInvestigacionController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public LineaInvestigacionController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/LineaInvestigacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<LineaInvestigacion>>> GetLineaInvestigacion()
        {
            return await _context.LineaInvestigacion.ToListAsync();
        }

        // GET: api/LineaInvestigacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<LineaInvestigacion>> GetLineaInvestigacion(int id)
        {
            var lineaInvestigacion = await _context.LineaInvestigacion.FindAsync(id);

            if (lineaInvestigacion == null)
            {
                return NotFound();
            }

            return lineaInvestigacion;
        }

        // PUT: api/LineaInvestigacion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutLineaInvestigacion(int id, LineaInvestigacion lineaInvestigacion)
        {
            if (id != lineaInvestigacion.LineaInvestigacionId)
            {
                return BadRequest();
            }

            _context.Entry(lineaInvestigacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!LineaInvestigacionExists(id))
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

        // POST: api/LineaInvestigacion
        [HttpPost]
        public async Task<ActionResult<LineaInvestigacion>> PostLineaInvestigacion(LineaInvestigacion lineaInvestigacion)
        {
            _context.LineaInvestigacion.Add(lineaInvestigacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetLineaInvestigacion", new { id = lineaInvestigacion.LineaInvestigacionId }, lineaInvestigacion);
        }

        // DELETE: api/LineaInvestigacion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<LineaInvestigacion>> DeleteLineaInvestigacion(int id)
        {
            var lineaInvestigacion = await _context.LineaInvestigacion.FindAsync(id);
            if (lineaInvestigacion == null)
            {
                return NotFound();
            }

            _context.LineaInvestigacion.Remove(lineaInvestigacion);
            await _context.SaveChangesAsync();

            return lineaInvestigacion;
        }

        private bool LineaInvestigacionExists(int id)
        {
            return _context.LineaInvestigacion.Any(e => e.LineaInvestigacionId == id);
        }
    }
}
