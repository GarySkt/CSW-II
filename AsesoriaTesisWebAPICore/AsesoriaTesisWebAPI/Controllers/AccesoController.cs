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
    public class AccesoController : ControllerBase
    {
        private readonly PostDbContext _context;

        public AccesoController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Acceso
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Acceso>>> GetAcceso()
        {
            return await _context.Acceso.ToListAsync();
        }

        // GET: api/Acceso/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Acceso>> GetAcceso(int id)
        {
            var acceso = await _context.Acceso.FindAsync(id);

            if (acceso == null)
            {
                return NotFound();
            }

            return acceso;
        }

        // PUT: api/Acceso/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAcceso(int id, Acceso acceso)
        {
            if (id != acceso.EntidadId)
            {
                return BadRequest();
            }

            _context.Entry(acceso).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AccesoExists(id))
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

        // POST: api/Acceso
        [HttpPost]
        public async Task<ActionResult<Acceso>> PostAcceso(Acceso acceso)
        {
            _context.Acceso.Add(acceso);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (AccesoExists(acceso.EntidadId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetAcceso", new { id = acceso.EntidadId }, acceso);
        }

        // DELETE: api/Acceso/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Acceso>> DeleteAcceso(int id)
        {
            var acceso = await _context.Acceso.FindAsync(id);
            if (acceso == null)
            {
                return NotFound();
            }

            _context.Acceso.Remove(acceso);
            await _context.SaveChangesAsync();

            return acceso;
        }

        private bool AccesoExists(int id)
        {
            return _context.Acceso.Any(e => e.EntidadId == id);
        }
    }
}
