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
    public class EntidadCicloController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public EntidadCicloController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/EntidadCiclo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntidadCiclo>>> GetEntidadCiclo()
        {
            return await _context.EntidadCiclo.ToListAsync();
        }

        // GET: api/EntidadCiclo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntidadCiclo>> GetEntidadCiclo(int id)
        {
            var entidadCiclo = await _context.EntidadCiclo.FindAsync(id);

            if (entidadCiclo == null)
            {
                return NotFound();
            }

            return entidadCiclo;
        }

        // PUT: api/EntidadCiclo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntidadCiclo(int id, EntidadCiclo entidadCiclo)
        {
            if (id != entidadCiclo.EntidadCicloId)
            {
                return BadRequest();
            }

            _context.Entry(entidadCiclo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntidadCicloExists(id))
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

        // POST: api/EntidadCiclo
        [HttpPost]
        public async Task<ActionResult<EntidadCiclo>> PostEntidadCiclo(EntidadCiclo entidadCiclo)
        {
            _context.EntidadCiclo.Add(entidadCiclo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntidadCiclo", new { id = entidadCiclo.EntidadCicloId }, entidadCiclo);
        }

        // DELETE: api/EntidadCiclo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntidadCiclo>> DeleteEntidadCiclo(int id)
        {
            var entidadCiclo = await _context.EntidadCiclo.FindAsync(id);
            if (entidadCiclo == null)
            {
                return NotFound();
            }

            _context.EntidadCiclo.Remove(entidadCiclo);
            await _context.SaveChangesAsync();

            return entidadCiclo;
        }

        private bool EntidadCicloExists(int id)
        {
            return _context.EntidadCiclo.Any(e => e.EntidadCicloId == id);
        }
    }
}
