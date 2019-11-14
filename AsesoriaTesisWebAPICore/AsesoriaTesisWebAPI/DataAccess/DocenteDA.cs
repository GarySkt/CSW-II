using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AsesoriaTesisWebAPI.Models;
using AsesoriaTesisWebAPI.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class DocenteDA 
    {
        
        private readonly PostDbContext dbContext;

        public DocenteDA()
        {
            dbContext = new PostDbContext();
        }

        /// <summary>
        /// Método que lista las especialidades de un determinado docente
        /// </summary>
        /// <param name="idDocente">ID de Docente</param>
        /// <returns>lista de especialidades</returns>
        public async Task<ActionResult<IEnumerable<DocenteEspecialidad>>> GetDocenteEspecialidad(int idDocente)
        {
            List<DocenteEspecialidad> listaDocente = new List<DocenteEspecialidad>();
            var listarEspecialidad = await dbContext.Especialidaddocente
                .Include(e => e.Especialidad)
                .Where(e => e.DocenteId.Equals(idDocente))
                .ToListAsync();

            foreach (var lista in listarEspecialidad)
            {
                DocenteEspecialidad docenteEspecialidad = new DocenteEspecialidad()
                {
                    DocenteID = lista.DocenteId,
                    EspecialidadID = lista.EspecialidadId,
                    EspecialidadNombre = lista.Especialidad.Nombre
                };

                listaDocente.Add(docenteEspecialidad);
            }

            return listaDocente;
            
        }

        /// <summary>
        /// Método que lista los docentes de una determinada especialidad
        /// </summary>
        /// <param name="idEspecialidad">ID de Especialidad</param>
        /// <returns>lista de docentes</returns>
        public async Task<ActionResult<IEnumerable<DocenteEspecialidad>>> GetEspecialidadDocente(int idEspecialidad)
        {
            List<DocenteEspecialidad> listaDocente = new List<DocenteEspecialidad>();

            var listarDocente = await (from ed in dbContext.Especialidaddocente
                                       join d in dbContext.Docente on ed.DocenteId equals d.DocenteId
                                       join e in dbContext.Escuela on d.EscuelaId equals e.EscuelaId
                                       join en in dbContext.Entidad on d.DocenteId equals en.EntidadId
                                       join p in dbContext.Persona on en.EntidadId equals p.EntidadId
                                       where ed.EspecialidadId == idEspecialidad
                                       select new DocenteEspecialidad
                                       {
                                           DocenteID = d.DocenteId,
                                           DocenteNombre = p.Nombre,
                                           DocenteApellido = p.Apellido,
                                           EscuelaID = e.EscuelaId,
                                           EscuelaNombre = e.Nombre
                                       }).ToListAsync();
            
            foreach (var lista in listarDocente)
            {
                DocenteEspecialidad docenteEspecialidad = new DocenteEspecialidad()
                {
                    DocenteID = lista.DocenteID,
                    DocenteNombre = lista.DocenteNombre,
                    DocenteApellido = lista.DocenteApellido,
                    EscuelaID = lista.EscuelaID,
                    EscuelaNombre = lista.EscuelaNombre
                };

                listaDocente.Add(docenteEspecialidad);
            }

            return listaDocente;

        }


    }
}


