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
    public class EntregableController : ControllerBase
    {
        private readonly PostDbContext _context;

        public EntregableController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Entregable
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Entregable>>> GetEntregable()
        {
            return await _context.Entregable.ToListAsync();
        }

        // GET: api/Entregable/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Entregable>> GetEntregable(int id)
        {
            var entregable = await _context.Entregable.FindAsync(id);

            if (entregable == null)
            {
                return NotFound();
            }

            return entregable;
        }

        // PUT: api/Entregable/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntregable(int id, Entregable entregable)
        {
            if (id != entregable.EntregableId)
            {
                return BadRequest();
            }

            _context.Entry(entregable).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntregableExists(id))
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

        // POST: api/Entregable
        [HttpPost]
        public async Task<ActionResult<Entregable>> PostEntregable(Entregable entregable)
        {
            _context.Entregable.Add(entregable);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntregable", new { id = entregable.EntregableId }, entregable);
        }

        // DELETE: api/Entregable/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Entregable>> DeleteEntregable(int id)
        {
            var entregable = await _context.Entregable.FindAsync(id);
            if (entregable == null)
            {
                return NotFound();
            }

            _context.Entregable.Remove(entregable);
            await _context.SaveChangesAsync();

            return entregable;
        }

        private bool EntregableExists(int id)
        {
            return _context.Entregable.Any(e => e.EntregableId == id);
        }
    }
}
