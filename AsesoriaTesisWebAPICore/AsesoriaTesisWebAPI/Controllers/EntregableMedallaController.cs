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
    public class EntregableMedallaController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public EntregableMedallaController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/EntregableMedalla
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntregableMedalla>>> GetEntregableMedalla()
        {
            return await _context.EntregableMedalla.ToListAsync();
        }

        // GET: api/EntregableMedalla/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntregableMedalla>> GetEntregableMedalla(int id)
        {
            var entregableMedalla = await _context.EntregableMedalla.FindAsync(id);

            if (entregableMedalla == null)
            {
                return NotFound();
            }

            return entregableMedalla;
        }

        // PUT: api/EntregableMedalla/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntregableMedalla(int id, EntregableMedalla entregableMedalla)
        {
            if (id != entregableMedalla.EntregableMedallaId)
            {
                return BadRequest();
            }

            _context.Entry(entregableMedalla).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntregableMedallaExists(id))
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

        // POST: api/EntregableMedalla
        [HttpPost]
        public async Task<ActionResult<EntregableMedalla>> PostEntregableMedalla(EntregableMedalla entregableMedalla)
        {
            _context.EntregableMedalla.Add(entregableMedalla);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntregableMedalla", new { id = entregableMedalla.EntregableMedallaId }, entregableMedalla);
        }

        // DELETE: api/EntregableMedalla/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntregableMedalla>> DeleteEntregableMedalla(int id)
        {
            var entregableMedalla = await _context.EntregableMedalla.FindAsync(id);
            if (entregableMedalla == null)
            {
                return NotFound();
            }

            _context.EntregableMedalla.Remove(entregableMedalla);
            await _context.SaveChangesAsync();

            return entregableMedalla;
        }

        private bool EntregableMedallaExists(int id)
        {
            return _context.EntregableMedalla.Any(e => e.EntregableMedallaId == id);
        }
    }
}
