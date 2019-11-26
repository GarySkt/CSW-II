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
    public class ActividadDA
    {
        private readonly TutoriaContext dbContext;

        public ActividadDA()
        {
            dbContext = new TutoriaContext();
        }

        public async Task<ActionResult<IEnumerable<ActividadDetalle>>> GetActividadDetalle()
        {

            var resultList = await (from act in dbContext.Actividad
                                    join actt in dbContext.ActividadTipo on act.ActividadTipoId equals actt.ActividadTipoId
                                    join ase in dbContext.Asesor on act.AsesorId equals ase.AsesorId
                                    join doc in dbContext.Docente on ase.AsesorId equals doc.DocenteId
                                    join ent in dbContext.Entidad on doc.DocenteId equals ent.EntidadId
                                    join per in dbContext.Persona on ent.EntidadId equals per.EntidadId
                                    join alu in dbContext.Alumno on act.AlumnoId equals alu.AlumnoId
                                    join enta in dbContext.Entidad on alu.AlumnoId equals enta.EntidadId
                                    join pera in dbContext.Persona on enta.EntidadId equals pera.EntidadId
                                    select new ActividadDetalle
                                    {
                                        ActividadId = act.ActividadId,
                                        Finalizada = act.Finalizada,
                                        AlumnoId = act.AlumnoId,
                                        CreditoAprobado = alu.CreditoAprobado,
                                        AlumnoEntidadID = enta.EntidadId,
                                        AlumnoEntidadActivo = enta.EstaActivo,
                                        AlumnoNombre = pera.Nombre,
                                        AlumnoApellido = pera.Apellido,
                                        ActividadTitulo = act.Titulo,
                                        ActividadResumen = act.Resumen,
                                        ActividadDescripcion = act.Descripcion,
                                        AsesorId = ase.AsesorId,
                                        DocenteID = doc.DocenteId,
                                        DocenteTitulo = doc.Titulo,
                                        DocenteEntidadID = ent.EntidadId,
                                        DocenteEntidadActivo = ent.EstaActivo,
                                        DocenteNombre = per.Nombre,
                                        DocenteApellido = per.Apellido,
                                        ActividadTipoId = act.ActividadTipoId,
                                        ActividadNombreTipo = actt.Nombre
                                    }).ToListAsync();


            return resultList;

        }

        public async Task<ActionResult<IEnumerable<ActividadDetalle>>> GetActividadDetalle(int idEntidad)
        {

            var resultList = await (from act in dbContext.Actividad
                                    join actt in dbContext.ActividadTipo on act.ActividadTipoId equals actt.ActividadTipoId
                                    join ase in dbContext.Asesor on act.AsesorId equals ase.AsesorId
                                    join doc in dbContext.Docente on ase.AsesorId equals doc.DocenteId
                                    join ent in dbContext.Entidad on doc.DocenteId equals ent.EntidadId
                                    join per in dbContext.Persona on ent.EntidadId equals per.EntidadId
                                    join alu in dbContext.Alumno on act.AlumnoId equals alu.AlumnoId
                                    join enta in dbContext.Entidad on alu.AlumnoId equals enta.EntidadId
                                    join pera in dbContext.Persona on enta.EntidadId equals pera.EntidadId
                                    where ent.EntidadId == idEntidad || enta.EntidadId == idEntidad
                                    select new ActividadDetalle
                                    {
                                        ActividadId = act.ActividadId,
                                        Finalizada = act.Finalizada,
                                        AlumnoId = act.AlumnoId,
                                        CreditoAprobado = alu.CreditoAprobado,
                                        AlumnoEntidadID = enta.EntidadId,
                                        AlumnoEntidadActivo = enta.EstaActivo,
                                        AlumnoNombre = pera.Nombre,
                                        AlumnoApellido = pera.Apellido,
                                        ActividadTitulo = act.Titulo,
                                        ActividadResumen = act.Resumen,
                                        ActividadDescripcion = act.Descripcion,
                                        AsesorId = ase.AsesorId,
                                        DocenteID = doc.DocenteId,
                                        DocenteTitulo = doc.Titulo,
                                        DocenteEntidadID = ent.EntidadId,
                                        DocenteEntidadActivo = ent.EstaActivo,
                                        DocenteNombre = per.Nombre,
                                        DocenteApellido = per.Apellido,
                                        ActividadTipoId = act.ActividadTipoId,
                                        ActividadNombreTipo = actt.Nombre
                                    }).ToListAsync();


            return resultList;

        }

    }
}
