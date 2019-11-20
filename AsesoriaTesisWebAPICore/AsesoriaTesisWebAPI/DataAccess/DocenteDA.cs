using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AsesoriaTesisWebAPI.Models;

using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AsesoriaTesisWebAPI.CustomModels;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class DocenteDA 
    {
        
        private readonly TutoriaContext dbContext;

        public DocenteDA()
        {
            dbContext = new TutoriaContext();
        }

        //Metodo
        /// <summary>
        /// Método que lista las lineas de investigacion de un determinado docente
        /// </summary>
        /// <param name="idDocente">ID de Docente</param>
        /// <returns>lista de lineas de investigacion</returns>
        public async Task<ActionResult<IEnumerable<DocenteLineaInvestigacion>>> GetDocenteLineaInvestigacion(int idDocente)
        {
            List<DocenteLineaInvestigacion> listaDocente = new List<DocenteLineaInvestigacion>();
            var listarEspecialidad = await dbContext.LineaInvestigacionDocente
                .Include(e => e.LineaInvestigacion)
                .Where(e => e.DocenteId.Equals(idDocente))
                .ToListAsync();

            foreach (var lista in listarEspecialidad)
            {
                DocenteLineaInvestigacion docenteLineaInvestigacion = new DocenteLineaInvestigacion()
                {
                    DocenteID = lista.DocenteId,
                    LineaInvestigacionID = lista.LineaInvestigacionId,
                    LineaNombre = lista.LineaInvestigacion.Nombre
                };

                listaDocente.Add(docenteLineaInvestigacion);
            }

            return listaDocente;
            
        }

        /// <summary>
        /// Método que lista los docentes de una determinada linea de investigacion
        /// </summary>
        /// <param name="idLineaInvestigacion">ID de Linea de Ingestigacion</param>
        /// <returns>lista de docentes</returns>
        public async Task<ActionResult<IEnumerable<DocenteLineaInvestigacion>>> GetLineaInvestigacionDocente(int idLineaInvestigacion)
        {
            List<DocenteLineaInvestigacion> listaDocente = new List<DocenteLineaInvestigacion>();

            var listarDocente = await (from ed in dbContext.LineaInvestigacionDocente
                                       join d in dbContext.Docente on ed.DocenteId equals d.DocenteId                                       
                                       join en in dbContext.Entidad on d.DocenteId equals en.EntidadId
                                       join p in dbContext.Persona on en.EntidadId equals p.EntidadId
                                       join e in dbContext.Escuela on en.EscuelaId equals e.EscuelaId
                                       where ed.LineaInvestigacionId == idLineaInvestigacion
                                       select new DocenteLineaInvestigacion
                                       {
                                           DocenteID = d.DocenteId,
                                           DocenteNombre = p.Nombre,
                                           DocenteApellido = p.Apellido,
                                           EscuelaID = e.EscuelaId,
                                           EscuelaNombre = e.Nombre
                                       }).ToListAsync();

            foreach (var lista in listarDocente)
            {
                DocenteLineaInvestigacion docenteEspecialidad = new DocenteLineaInvestigacion()
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
