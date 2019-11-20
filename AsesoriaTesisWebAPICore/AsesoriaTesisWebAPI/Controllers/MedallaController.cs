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
    public class MedallaController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public MedallaController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/Medalla
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medalla>>> GetMedalla()
        {
            return await _context.Medalla.ToListAsync();
        }

        // GET: api/Medalla/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medalla>> GetMedalla(int id)
        {
            var medalla = await _context.Medalla.FindAsync(id);

            if (medalla == null)
            {
                return NotFound();
            }

            return medalla;
        }

        // PUT: api/Medalla/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedalla(int id, Medalla medalla)
        {
            if (id != medalla.MedallaId)
            {
                return BadRequest();
            }

            _context.Entry(medalla).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedallaExists(id))
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

        // POST: api/Medalla
        [HttpPost]
        public async Task<ActionResult<Medalla>> PostMedalla(Medalla medalla)
        {
            _context.Medalla.Add(medalla);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedalla", new { id = medalla.MedallaId }, medalla);
        }

        // DELETE: api/Medalla/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medalla>> DeleteMedalla(int id)
        {
            var medalla = await _context.Medalla.FindAsync(id);
            if (medalla == null)
            {
                return NotFound();
            }

            _context.Medalla.Remove(medalla);
            await _context.SaveChangesAsync();

            return medalla;
        }

        private bool MedallaExists(int id)
        {
            return _context.Medalla.Any(e => e.MedallaId == id);
        }
    }
}
