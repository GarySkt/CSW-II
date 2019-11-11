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
    public class ActividadtipoController : ControllerBase
    {
        private readonly PostDbContext _context;

        public ActividadtipoController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Actividadtipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actividadtipo>>> GetActividadtipo()
        {
            return await _context.Actividadtipo.ToListAsync();
        }

        // GET: api/Actividadtipo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Actividadtipo>> GetActividadtipo(int id)
        {
            var actividadtipo = await _context.Actividadtipo.FindAsync(id);

            if (actividadtipo == null)
            {
                return NotFound();
            }

            return actividadtipo;
        }

        // PUT: api/Actividadtipo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActividadtipo(int id, Actividadtipo actividadtipo)
        {
            if (id != actividadtipo.ActividadTipoId)
            {
                return BadRequest();
            }

            _context.Entry(actividadtipo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActividadtipoExists(id))
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

        // POST: api/Actividadtipo
        [HttpPost]
        public async Task<ActionResult<Actividadtipo>> PostActividadtipo(Actividadtipo actividadtipo)
        {
            _context.Actividadtipo.Add(actividadtipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActividadtipo", new { id = actividadtipo.ActividadTipoId }, actividadtipo);
        }

        // DELETE: api/Actividadtipo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Actividadtipo>> DeleteActividadtipo(int id)
        {
            var actividadtipo = await _context.Actividadtipo.FindAsync(id);
            if (actividadtipo == null)
            {
                return NotFound();
            }

            _context.Actividadtipo.Remove(actividadtipo);
            await _context.SaveChangesAsync();

            return actividadtipo;
        }

        private bool ActividadtipoExists(int id)
        {
            return _context.Actividadtipo.Any(e => e.ActividadTipoId == id);
        }
    }
}
