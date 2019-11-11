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
    public class MedallatipoController : ControllerBase
    {
        private readonly PostDbContext _context;

        public MedallatipoController(PostDbContext context)
        {
            _context = context;
        }

        // GET: api/Medallatipo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medallatipo>>> GetMedallatipo()
        {
            return await _context.Medallatipo.ToListAsync();
        }

        // GET: api/Medallatipo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medallatipo>> GetMedallatipo(int id)
        {
            var medallatipo = await _context.Medallatipo.FindAsync(id);

            if (medallatipo == null)
            {
                return NotFound();
            }

            return medallatipo;
        }

        // PUT: api/Medallatipo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedallatipo(int id, Medallatipo medallatipo)
        {
            if (id != medallatipo.MedallaTipoId)
            {
                return BadRequest();
            }

            _context.Entry(medallatipo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedallatipoExists(id))
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

        // POST: api/Medallatipo
        [HttpPost]
        public async Task<ActionResult<Medallatipo>> PostMedallatipo(Medallatipo medallatipo)
        {
            _context.Medallatipo.Add(medallatipo);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedallatipo", new { id = medallatipo.MedallaTipoId }, medallatipo);
        }

        // DELETE: api/Medallatipo/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medallatipo>> DeleteMedallatipo(int id)
        {
            var medallatipo = await _context.Medallatipo.FindAsync(id);
            if (medallatipo == null)
            {
                return NotFound();
            }

            _context.Medallatipo.Remove(medallatipo);
            await _context.SaveChangesAsync();

            return medallatipo;
        }

        private bool MedallatipoExists(int id)
        {
            return _context.Medallatipo.Any(e => e.MedallaTipoId == id);
        }
    }
}
