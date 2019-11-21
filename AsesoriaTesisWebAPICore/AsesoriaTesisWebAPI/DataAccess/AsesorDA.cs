using AsesoriaTesisWebAPI.CustomModels;
using AsesoriaTesisWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class AsesorDA
    {
        private readonly TutoriaContext dbContext;

        public AsesorDA()
        {
            dbContext = new TutoriaContext();
        }

        public async Task<ActionResult<IEnumerable<EntidadAsesor>>> GetAsesorEscuela(int idEscuela)
        {            
            var resultList = await (from a in dbContext.Asesor
                                    join d in dbContext.Docente on a.AsesorId equals d.DocenteId
                                    join en in dbContext.Entidad on d.DocenteId equals en.EntidadId
                                    join es in dbContext.Escuela on en.EscuelaId equals es.EscuelaId
                                    join p in dbContext.Persona on en.EntidadId equals p.EntidadId
                                    where es.EscuelaId == idEscuela
                                    select new EntidadAsesor
                                    {
                                        AsesorID = a.AsesorId,
                                        Disponibilidad = a.Disponibilidad,
                                        DocenteID = d.DocenteId,
                                        DocenteTitulo = d.Titulo,
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
