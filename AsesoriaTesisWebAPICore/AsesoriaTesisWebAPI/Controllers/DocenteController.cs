using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsesoriaTesisWebAPI.Models;
using AsesoriaTesisWebAPI.DataAccess;
using AsesoriaTesisWebAPI.Entity;

namespace AsesoriaTesisWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DocenteController : ControllerBase
    {
        private readonly PostDbContext _context;
        private DocenteDA docenteDA;

        public DocenteController(PostDbContext context)
        {
            _context = context;
            docenteDA = new DocenteDA();
        }

        // GET: api/Docente
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Docente>>> GetDocente()
        {
            return await _context.Docente
                .Include(d=> d.Asesor)
                .Include(d => d.Escuela)
                .ToListAsync();
        }

        // GET: api/Docente/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Docente>> GetDocente(int id)
        {
            var docente = await _context.Docente.FindAsync(id);

            if (docente == null)
            {
                return NotFound();
            }

            return docente;
        }

        // GET: api/Docente/GetEspecialidadDocente/1
        [HttpGet]
        [Route("[action]/{idEspecialidad}")]
        public async Task<ActionResult<IEnumerable<DocenteEspecialidad>>> GetEspecialidadDocente(int idEspecialidad)
        {
            var docente = await docenteDA.GetEspecialidadDocente(idEspecialidad);

            if (docente == null)
            {
                return NotFound();
            }

            return docente;
        }
              
        // GET: api/Docente/GetDocenteEspecialidad/1
        [HttpGet]
        [Route("[action]/{idDocente}")]
        public async Task<ActionResult<IEnumerable<DocenteEspecialidad>>> GetDocenteEspecialidad(int idDocente)
        {
            var docente = await docenteDA.GetDocenteEspecialidad(idDocente);

            if (docente == null)
            {
                return NotFound();
            }

            return docente;
        }

        // PUT: api/Docente/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDocente(int id, Docente docente)
        {
            if (id != docente.DocenteId)
            {
                return BadRequest();
            }

            _context.Entry(docente).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DocenteExists(id))
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
               

        // POST: api/Docente
        [HttpPost]
        public async Task<ActionResult<Docente>> PostDocente(Docente docente)
        {
            _context.Docente.Add(docente);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (DocenteExists(docente.DocenteId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetDocente", new { id = docente.DocenteId }, docente);
        }

        // DELETE: api/Docente/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Docente>> DeleteDocente(int id)
        {
            var docente = await _context.Docente.FindAsync(id);
            if (docente == null)
            {
                return NotFound();
            }

            _context.Docente.Remove(docente);
            await _context.SaveChangesAsync();

            return docente;
        }

        private bool DocenteExists(int id)
        {
            return _context.Docente.Any(e => e.DocenteId == id);
        }
    }
}
