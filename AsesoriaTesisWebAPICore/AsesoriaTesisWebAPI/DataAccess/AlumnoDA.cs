using AsesoriaTesisWebAPI.Models;
using AsesoriaTesisWebAPI.CustomModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class AlumnoDA
    {
        private readonly TutoriaContext dbContext;

        public AlumnoDA()
        {
            dbContext = new TutoriaContext();
        }

        public async Task<ActionResult<IEnumerable<EntidadAlumno>>> GetAlumnoEscuela(int idEscuela)
        {
            //List<EntidadAlumno> listaAlumno = new List<EntidadAlumno>();
            var resultList = await (from a in dbContext.Alumno
                                    join en in dbContext.Entidad on a.AlumnoId equals en.EntidadId
                                    join es in dbContext.Escuela on en.EscuelaId equals es.EscuelaId
                                    join p in dbContext.Persona on en.EntidadId equals p.EntidadId
                                    where es.EscuelaId == idEscuela
                                    select new EntidadAlumno
                                    {
                                        AlumnoID = a.AlumnoId,
                                        CreditoAprobado = a.CreditoAprobado,
                                        EntidadID = en.EntidadId,
                                        RolID = en.RolId,
                                        EntidadActivo = en.EstaActivo,
                                        PersonaNombre = p.Nombre,
                                        PersonaApellido = p.Apellido,
                                        EscuelaID = es.EscuelaId,
                                        EscuelaNombre = es.Nombre,
                                        FacultadID = es.FacultadId
                                    }
                                ).ToListAsync();

            return resultList;
        }

    }
}
