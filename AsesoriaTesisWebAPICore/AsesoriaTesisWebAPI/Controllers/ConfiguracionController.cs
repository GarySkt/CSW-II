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
    public class ConfiguracionController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public ConfiguracionController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/Configuracion
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Configuracion>>> GetConfiguracion()
        {
            return await _context.Configuracion.ToListAsync();
        }

        // GET: api/Configuracion/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Configuracion>> GetConfiguracion(int id)
        {
            var configuracion = await _context.Configuracion.FindAsync(id);

            if (configuracion == null)
            {
                return NotFound();
            }

            return configuracion;
        }

        // PUT: api/Configuracion/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutConfiguracion(int id, Configuracion configuracion)
        {
            if (id != configuracion.ConfiguracionId)
            {
                return BadRequest();
            }

            _context.Entry(configuracion).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ConfiguracionExists(id))
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

        // POST: api/Configuracion
        [HttpPost]
        public async Task<ActionResult<Configuracion>> PostConfiguracion(Configuracion configuracion)
        {
            _context.Configuracion.Add(configuracion);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetConfiguracion", new { id = configuracion.ConfiguracionId }, configuracion);
        }

        // DELETE: api/Configuracion/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Configuracion>> DeleteConfiguracion(int id)
        {
            var configuracion = await _context.Configuracion.FindAsync(id);
            if (configuracion == null)
            {
                return NotFound();
            }

            _context.Configuracion.Remove(configuracion);
            await _context.SaveChangesAsync();

            return configuracion;
        }

        private bool ConfiguracionExists(int id)
        {
            return _context.Configuracion.Any(e => e.ConfiguracionId == id);
        }
    }
}
