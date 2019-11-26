using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsesoriaTesisWebAPI.Models;
using AsesoriaTesisWebAPI.DataAccess;
using AsesoriaTesisWebAPI.CustomModels;

namespace AsesoriaTesisWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ActividadController : ControllerBase
    {
        private readonly TutoriaContext _context;
        private ActividadDA actividadDA;

        public ActividadController(TutoriaContext context)
        {
            _context = context;
            actividadDA = new ActividadDA();
        }

        // GET: api/Actividad
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Actividad>>> GetActividad()
        {
            return await _context.Actividad.ToListAsync();
        }

        // GET: api/Actividad/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Actividad>> GetActividad(int id)
        {
            var actividad = await _context.Actividad.FindAsync(id);

            if (actividad == null)
            {
                return NotFound();
            }

            return actividad;
        }

        // PUT: api/Actividad/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutActividad(int id, Actividad actividad)
        {
            if (id != actividad.ActividadId)
            {
                return BadRequest();
            }

            _context.Entry(actividad).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ActividadExists(id))
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

        // POST: api/Actividad
        [HttpPost]
        public async Task<ActionResult<Actividad>> PostActividad(Actividad actividad)
        {
            _context.Actividad.Add(actividad);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetActividad", new { id = actividad.ActividadId }, actividad);
        }

        // DELETE: api/Actividad/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Actividad>> DeleteActividad(int id)
        {
            var actividad = await _context.Actividad.FindAsync(id);
            if (actividad == null)
            {
                return NotFound();
            }

            _context.Actividad.Remove(actividad);
            await _context.SaveChangesAsync();

            return actividad;
        }

        private bool ActividadExists(int id)
        {
            return _context.Actividad.Any(e => e.ActividadId == id);
        }

        /////// METODOS AGREGADOS ///////

        [HttpGet]
        [Route("[action]")]
        public async Task<ActionResult<IEnumerable<ActividadDetalle>>> GetActividadDetalle()
        {
            var actividad = await actividadDA.GetActividadDetalle();

            if (actividad == null)
            {
                return NotFound();
            }

            return actividad;
        }

        [HttpGet]
        [Route("[action]/{idEntidad}")]
        public async Task<ActionResult<IEnumerable<ActividadDetalle>>> GetActividadDetalle(int idEntidad)
        {
            var actividad = await actividadDA.GetActividadDetalle(idEntidad);

            if (actividad == null)
            {
                return NotFound();
            }

            return actividad;
        }

    }
}
