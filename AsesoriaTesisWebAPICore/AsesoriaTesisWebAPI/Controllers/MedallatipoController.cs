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
    public class MedallaTipoController : ControllerBase
    {
        private readonly TutoriaContext _context;

        public MedallaTipoController(TutoriaContext context)
        {
            _context = context;
        }

        // GET: api/MedallaTipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<MedallaTipo>>> GetMedallaTipo()
        {
            return await _context.MedallaTipo.ToListAsync();
        }

        // GET: api/MedallaTipo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<MedallaTipo>> GetMedallaTipo(int id)
        {
            var medallaTipo = await _context.MedallaTipo.FindAsync(id);

            if (medallaTipo == null)
            {
                return NotFound();
            }

            return medallaTipo;
        }

        // PUT: api/MedallaTipo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedallaTipo(int id, MedallaTipo medallaTipo)
        {
            if (id != medallaTipo.MedallaTipoId)
            {
                return BadRequest();
            }

            _context.Entry(medallaTipo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedallaTipoExists(id))
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

        // POST: api/MedallaTipo
        [HttpPost]
        public async Task<ActionResult<MedallaTipo>> PostMedallaTipo(MedallaTipo medallaTipo)
        {
            _context.MedallaTipo.Add(medallaTipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedallaTipo", new { id = medallaTipo.MedallaTipoId }, medallaTipo);
        }

        // DELETE: api/MedallaTipo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<MedallaTipo>> DeleteMedallaTipo(int id)
        {
            var medallaTipo = await _context.MedallaTipo.FindAsync(id);
            if (medallaTipo == null)
            {
                return NotFound();
            }

            _context.MedallaTipo.Remove(medallaTipo);
            await _context.SaveChangesAsync();

            return medallaTipo;
        }

        private bool MedallaTipoExists(int id)
        {
            return _context.MedallaTipo.Any(e => e.MedallaTipoId == id);
        }
    }
}
