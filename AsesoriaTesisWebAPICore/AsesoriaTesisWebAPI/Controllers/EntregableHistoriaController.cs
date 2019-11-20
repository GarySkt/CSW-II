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
    public class EntregableHistoriaController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public EntregableHistoriaController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/EntregableHistoria
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntregableHistoria>>> GetEntregableHistoria()
        {
            return await _context.EntregableHistoria.ToListAsync();
        }

        // GET: api/EntregableHistoria/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntregableHistoria>> GetEntregableHistoria(int id)
        {
            var entregableHistoria = await _context.EntregableHistoria.FindAsync(id);

            if (entregableHistoria == null)
            {
                return NotFound();
            }

            return entregableHistoria;
        }

        // PUT: api/EntregableHistoria/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntregableHistoria(int id, EntregableHistoria entregableHistoria)
        {
            if (id != entregableHistoria.EntregableHistoriaId)
            {
                return BadRequest();
            }

            _context.Entry(entregableHistoria).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntregableHistoriaExists(id))
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

        // POST: api/EntregableHistoria
        [HttpPost]
        public async Task<ActionResult<EntregableHistoria>> PostEntregableHistoria(EntregableHistoria entregableHistoria)
        {
            _context.EntregableHistoria.Add(entregableHistoria);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntregableHistoria", new { id = entregableHistoria.EntregableHistoriaId }, entregableHistoria);
        }

        // DELETE: api/EntregableHistoria/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntregableHistoria>> DeleteEntregableHistoria(int id)
        {
            var entregableHistoria = await _context.EntregableHistoria.FindAsync(id);
            if (entregableHistoria == null)
            {
                return NotFound();
            }

            _context.EntregableHistoria.Remove(entregableHistoria);
            await _context.SaveChangesAsync();

            return entregableHistoria;
        }

        private bool EntregableHistoriaExists(int id)
        {
            return _context.EntregableHistoria.Any(e => e.EntregableHistoriaId == id);
        }
    }
}
