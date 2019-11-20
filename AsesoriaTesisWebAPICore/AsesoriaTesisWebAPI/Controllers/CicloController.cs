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
    public class CicloController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public CicloController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/Ciclo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Ciclo>>> GetCiclo()
        {
            return await _context.Ciclo.ToListAsync();
        }

        // GET: api/Ciclo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Ciclo>> GetCiclo(int id)
        {
            var ciclo = await _context.Ciclo.FindAsync(id);

            if (ciclo == null)
            {
                return NotFound();
            }

            return ciclo;
        }

        // PUT: api/Ciclo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCiclo(int id, Ciclo ciclo)
        {
            if (id != ciclo.CicloId)
            {
                return BadRequest();
            }

            _context.Entry(ciclo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CicloExists(id))
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

        // POST: api/Ciclo
        [HttpPost]
        public async Task<ActionResult<Ciclo>> PostCiclo(Ciclo ciclo)
        {
            _context.Ciclo.Add(ciclo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCiclo", new { id = ciclo.CicloId }, ciclo);
        }

        // DELETE: api/Ciclo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Ciclo>> DeleteCiclo(int id)
        {
            var ciclo = await _context.Ciclo.FindAsync(id);
            if (ciclo == null)
            {
                return NotFound();
            }

            _context.Ciclo.Remove(ciclo);
            await _context.SaveChangesAsync();

            return ciclo;
        }

        private bool CicloExists(int id)
        {
            return _context.Ciclo.Any(e => e.CicloId == id);
        }
    }
}
