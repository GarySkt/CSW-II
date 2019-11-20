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
    public class AsesorController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public AsesorController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/Asesor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Asesor>>> GetAsesor()
        {
            return await _context.Asesor.ToListAsync();
        }

        // GET: api/Asesor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Asesor>> GetAsesor(int id)
        {
            var asesor = await _context.Asesor.FindAsync(id);

            if (asesor == null)
            {
                return NotFound();
            }

            return asesor;
        }

        // PUT: api/Asesor/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAsesor(int id, Asesor asesor)
        {
            if (id != asesor.AsesorId)
            {
                return BadRequest();
            }

            _context.Entry(asesor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AsesorExists(id))
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

        // POST: api/Asesor
        [HttpPost]
        public async Task<ActionResult<Asesor>> PostAsesor(Asesor asesor)
        {
            _context.Asesor.Add(asesor);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AsesorExists(asesor.AsesorId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAsesor", new { id = asesor.AsesorId }, asesor);
        }

        // DELETE: api/Asesor/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Asesor>> DeleteAsesor(int id)
        {
            var asesor = await _context.Asesor.FindAsync(id);
            if (asesor == null)
            {
                return NotFound();
            }

            _context.Asesor.Remove(asesor);
            await _context.SaveChangesAsync();

            return asesor;
        }

        private bool AsesorExists(int id)
        {
            return _context.Asesor.Any(e => e.AsesorId == id);
        }
    }
}
