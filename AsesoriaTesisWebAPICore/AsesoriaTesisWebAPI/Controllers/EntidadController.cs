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
    public class EntidadController : ControllerBase
    {
        private readonly PostDbContext _context;

        public EntidadController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Entidad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entidad>>> GetEntidad()
        {
            return await _context.Entidad.ToListAsync();
        }

        // GET: api/Entidad/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entidad>> GetEntidad(int id)
        {
            var entidad = await _context.Entidad.FindAsync(id);

            if (entidad == null)
            {
                return NotFound();
            }

            return entidad;
        }

        // PUT: api/Entidad/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntidad(int id, Entidad entidad)
        {
            if (id != entidad.EntidadId)
            {
                return BadRequest();
            }

            _context.Entry(entidad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntidadExists(id))
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

        // POST: api/Entidad
        [HttpPost]
        public async Task<ActionResult<Entidad>> PostEntidad(Entidad entidad)
        {
            _context.Entidad.Add(entidad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntidad", new { id = entidad.EntidadId }, entidad);
        }

        // DELETE: api/Entidad/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Entidad>> DeleteEntidad(int id)
        {
            var entidad = await _context.Entidad.FindAsync(id);
            if (entidad == null)
            {
                return NotFound();
            }

            _context.Entidad.Remove(entidad);
            await _context.SaveChangesAsync();

            return entidad;
        }

        private bool EntidadExists(int id)
        {
            return _context.Entidad.Any(e => e.EntidadId == id);
        }
    }
}
