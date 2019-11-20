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
    public class EntregableEstadoController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public EntregableEstadoController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/EntregableEstado
        [HttpGet]
        public async Task<ActionResult<IEnumerable<EntregableEstado>>> GetEntregableEstado()
        {
            return await _context.EntregableEstado.ToListAsync();
        }

        // GET: api/EntregableEstado/5
        [HttpGet("{id}")]
        public async Task<ActionResult<EntregableEstado>> GetEntregableEstado(int id)
        {
            var entregableEstado = await _context.EntregableEstado.FindAsync(id);

            if (entregableEstado == null)
            {
                return NotFound();
            }

            return entregableEstado;
        }

        // PUT: api/EntregableEstado/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEntregableEstado(int id, EntregableEstado entregableEstado)
        {
            if (id != entregableEstado.EntregableEstadoId)
            {
                return BadRequest();
            }

            _context.Entry(entregableEstado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EntregableEstadoExists(id))
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

        // POST: api/EntregableEstado
        [HttpPost]
        public async Task<ActionResult<EntregableEstado>> PostEntregableEstado(EntregableEstado entregableEstado)
        {
            _context.EntregableEstado.Add(entregableEstado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetEntregableEstado", new { id = entregableEstado.EntregableEstadoId }, entregableEstado);
        }

        // DELETE: api/EntregableEstado/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<EntregableEstado>> DeleteEntregableEstado(int id)
        {
            var entregableEstado = await _context.EntregableEstado.FindAsync(id);
            if (entregableEstado == null)
            {
                return NotFound();
            }

            _context.EntregableEstado.Remove(entregableEstado);
            await _context.SaveChangesAsync();

            return entregableEstado;
        }

        private bool EntregableEstadoExists(int id)
        {
            return _context.EntregableEstado.Any(e => e.EntregableEstadoId == id);
        }
    }
}
