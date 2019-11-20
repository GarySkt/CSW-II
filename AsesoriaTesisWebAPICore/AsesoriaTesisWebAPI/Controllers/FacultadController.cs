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
    public class FacultadController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public FacultadController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/Facultad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Facultad>>> GetFacultad()
        {
            return await _context.Facultad.ToListAsync();
        }

        // GET: api/Facultad/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Facultad>> GetFacultad(int id)
        {
            var facultad = await _context.Facultad.FindAsync(id);

            if (facultad == null)
            {
                return NotFound();
            }

            return facultad;
        }

        // PUT: api/Facultad/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutFacultad(int id, Facultad facultad)
        {
            if (id != facultad.FacultadId)
            {
                return BadRequest();
            }

            _context.Entry(facultad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!FacultadExists(id))
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

        // POST: api/Facultad
        [HttpPost]
        public async Task<ActionResult<Facultad>> PostFacultad(Facultad facultad)
        {
            _context.Facultad.Add(facultad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetFacultad", new { id = facultad.FacultadId }, facultad);
        }

        // DELETE: api/Facultad/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Facultad>> DeleteFacultad(int id)
        {
            var facultad = await _context.Facultad.FindAsync(id);
            if (facultad == null)
            {
                return NotFound();
            }

            _context.Facultad.Remove(facultad);
            await _context.SaveChangesAsync();

            return facultad;
        }

        private bool FacultadExists(int id)
        {
            return _context.Facultad.Any(e => e.FacultadId == id);
        }
    }
}
