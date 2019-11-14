using System;
using Microsoft.AspNetCore.Http;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using AsesoriaTesisWebAPI.Models;
using AsesoriaTesisWebAPI.DTOs;
using MySql.Data.MySqlClient;

namespace AsesoriaTesisWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedallaController : ControllerBase
    {
        private readonly PostDbContext _context;
        
        public MedallaController(PostDbContext context)
        {
            _context = context;
        }
        
        [HttpGet]
        public List<MedallaDTO> Get()
        {
            var medallas = (from me in _context.Medalla
                          join ti in _context.Medallatipo on me.MedallaTipoId equals ti.MedallaTipoId
                          select new MedallaDTO()
                          {
                              MedallaId = me.MedallaId,
                              Nombre = me.Nombre,
                              ImagenUrl = me.ImagenUrl,
                              Descripcion = me.Descripcion,
                              MedallaTipoRelacional = new MedallaTipoDTO()
                              {
                                  MedallaTipoId = ti.MedallaTipoId,
                                  Nombre = ti.Nombre,
                                  Descripcion = ti.Descripcion
                              }
                          }).ToList();
            return medallas;
        }

        /*
        // GET: api/Medalla
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Medalla>>> GetMedalla()
        {
            return await _context.Medalla.ToListAsync();
        }*/

        /*
        [HttpGet("{id}", Name = "medallacreada")]
        public IActionResult GetById(int id)
        {
            var medalla = (from me in _context.Medalla
                           join ti in _context.Medallatipo on me.MedallaTipoId equals ti.MedallaTipoId
                           select new MedallaDTO()
                           {
                               MedallaId = me.MedallaId,
                               Nombre = me.Nombre,
                               ImagenUrl = me.ImagenUrl,
                               Descripcion = me.Descripcion,
                               MedallaTipoRelacional = new MedallaDTO()
                               {
                                   MedallaTipoId = ti.MedallaTipoId,
                                   Nombre = ti.Nombre,
                                   Descripcion = ti.Descripcion
                               }
                           }).FirstOrDefault(x => x.IdCurso == id);

            if (medalla == null)
            {
                return NotFound();
            }

            return Ok(medalla);
        }*/

 
        // GET: api/Medalla/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Medalla>> GetMedalla(int id)
        {
            var medalla = await _context.Medalla.FindAsync(id);

            if (medalla == null)
            {
                return NotFound();
            }

            return medalla;
        }

        // PUT: api/Medalla/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMedalla(int id, Medalla medalla)
        {
            if (id != medalla.MedallaId)
            {
                return BadRequest();
            }

            _context.Entry(medalla).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MedallaExists(id))
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

        // POST: api/Medalla
        [HttpPost]
        public async Task<ActionResult<Medalla>> PostMedalla(Medalla medalla)
        {
            _context.Medalla.Add(medalla);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetMedalla", new { id = medalla.MedallaId }, medalla);
        }

        // DELETE: api/Medalla/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Medalla>> DeleteMedalla(int id)
        {
            var medalla = await _context.Medalla.FindAsync(id);
            if (medalla == null)
            {
                return NotFound();
            }

            _context.Medalla.Remove(medalla);
            await _context.SaveChangesAsync();

            return medalla;
        }

        private bool MedallaExists(int id)
        {
            return _context.Medalla.Any(e => e.MedallaId == id);
        }
    }
}
