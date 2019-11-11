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
    public class EspecialidaddocenteController : ControllerBase
    {
        private readonly PostDbContext _context;

        public EspecialidaddocenteController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Especialidaddocente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Especialidaddocente>>> GetEspecialidaddocente()
        {
            return await _context.Especialidaddocente.ToListAsync();
        }

        // GET: api/Especialidaddocente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Especialidaddocente>> GetEspecialidaddocente(int id)
        {
            var especialidaddocente = await _context.Especialidaddocente.FindAsync(id);

            if (especialidaddocente == null)
            {
                return NotFound();
            }

            return especialidaddocente;
        }

        // PUT: api/Especialidaddocente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEspecialidaddocente(int id, Especialidaddocente especialidaddocente)
        {
            if (id != especialidaddocente.EspecialidadDocenteId)
            {
                return BadRequest();
            }

            _context.Entry(especialidaddocente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EspecialidaddocenteExists(id))
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

        // POST: api/Especialidaddocente
        [HttpPost]
        public async Task<ActionResult<Especialidaddocente>> PostEspecialidaddocente(Especialidaddocente especialidaddocente)
        {
            _context.Especialidaddocente.Add(especialidaddocente);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEspecialidaddocente", new { id = especialidaddocente.EspecialidadDocenteId }, especialidaddocente);
        }

        // DELETE: api/Especialidaddocente/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Especialidaddocente>> DeleteEspecialidaddocente(int id)
        {
            var especialidaddocente = await _context.Especialidaddocente.FindAsync(id);
            if (especialidaddocente == null)
            {
                return NotFound();
            }

            _context.Especialidaddocente.Remove(especialidaddocente);
            await _context.SaveChangesAsync();

            return especialidaddocente;
        }

        private bool EspecialidaddocenteExists(int id)
        {
            return _context.Especialidaddocente.Any(e => e.EspecialidadDocenteId == id);
        }
    }
}
