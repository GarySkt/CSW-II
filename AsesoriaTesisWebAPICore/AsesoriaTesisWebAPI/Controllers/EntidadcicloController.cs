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
    public class EntidadcicloController : ControllerBase
    {
        private readonly PostDbContext _context;

        public EntidadcicloController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Entidadciclo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entidadciclo>>> GetEntidadciclo()
        {
            return await _context.Entidadciclo.ToListAsync();
        }

        // GET: api/Entidadciclo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entidadciclo>> GetEntidadciclo(int id)
        {
            var entidadciclo = await _context.Entidadciclo.FindAsync(id);

            if (entidadciclo == null)
            {
                return NotFound();
            }

            return entidadciclo;
        }

        // PUT: api/Entidadciclo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntidadciclo(int id, Entidadciclo entidadciclo)
        {
            if (id != entidadciclo.EntidadCicloId)
            {
                return BadRequest();
            }

            _context.Entry(entidadciclo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntidadcicloExists(id))
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

        // POST: api/Entidadciclo
        [HttpPost]
        public async Task<ActionResult<Entidadciclo>> PostEntidadciclo(Entidadciclo entidadciclo)
        {
            _context.Entidadciclo.Add(entidadciclo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntidadciclo", new { id = entidadciclo.EntidadCicloId }, entidadciclo);
        }

        // DELETE: api/Entidadciclo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Entidadciclo>> DeleteEntidadciclo(int id)
        {
            var entidadciclo = await _context.Entidadciclo.FindAsync(id);
            if (entidadciclo == null)
            {
                return NotFound();
            }

            _context.Entidadciclo.Remove(entidadciclo);
            await _context.SaveChangesAsync();

            return entidadciclo;
        }

        private bool EntidadcicloExists(int id)
        {
            return _context.Entidadciclo.Any(e => e.EntidadCicloId == id);
        }
    }
}
