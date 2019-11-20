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
    public class AreaInvestigacionController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public AreaInvestigacionController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/AreaInvestigacion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<AreaInvestigacion>>> GetAreaInvestigacion()
        {
            return await _context.AreaInvestigacion.ToListAsync();
        }

        // GET: api/AreaInvestigacion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<AreaInvestigacion>> GetAreaInvestigacion(int id)
        {
            var areaInvestigacion = await _context.AreaInvestigacion.FindAsync(id);

            if (areaInvestigacion == null)
            {
                return NotFound();
            }

            return areaInvestigacion;
        }

        // PUT: api/AreaInvestigacion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAreaInvestigacion(int id, AreaInvestigacion areaInvestigacion)
        {
            if (id != areaInvestigacion.AreaInvestigacionId)
            {
                return BadRequest();
            }

            _context.Entry(areaInvestigacion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AreaInvestigacionExists(id))
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

        // POST: api/AreaInvestigacion
        [HttpPost]
        public async Task<ActionResult<AreaInvestigacion>> PostAreaInvestigacion(AreaInvestigacion areaInvestigacion)
        {
            _context.AreaInvestigacion.Add(areaInvestigacion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAreaInvestigacion", new { id = areaInvestigacion.AreaInvestigacionId }, areaInvestigacion);
        }

        // DELETE: api/AreaInvestigacion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<AreaInvestigacion>> DeleteAreaInvestigacion(int id)
        {
            var areaInvestigacion = await _context.AreaInvestigacion.FindAsync(id);
            if (areaInvestigacion == null)
            {
                return NotFound();
            }

            _context.AreaInvestigacion.Remove(areaInvestigacion);
            await _context.SaveChangesAsync();

            return areaInvestigacion;
        }

        private bool AreaInvestigacionExists(int id)
        {
            return _context.AreaInvestigacion.Any(e => e.AreaInvestigacionId == id);
        }
    }
}
