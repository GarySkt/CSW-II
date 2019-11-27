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
    public class EntregableDA
    {
        private readonly TutoriaContext dbContext;
        private EntregableEstadoDA entregableEstadoDA;

        public EntregableDA()
        {
            dbContext = new TutoriaContext();
            entregableEstadoDA = new EntregableEstadoDA();
        }

        /// <summary>
        /// Obtiene la ultima medalla asignada a un determinado entregable
        /// </summary>
        /// <param name="idActividad"></param>
        /// <returns></returns>
        public async Task<ActionResult<IEnumerable<EntregableMedallaDetalle>>> GetEntregableMedallaUltimo(int idActividad)
        {
            List<EntregableMedallaDetalle> medallaList = new List<EntregableMedallaDetalle>();
            var resultList = await (from entm in dbContext.EntregableMedalla                                    
                                    join ent in dbContext.Entregable on entm.EntregableId equals ent.EntregableId
                                    join med in dbContext.Medalla on entm.MedallaId equals med.MedallaId
                                    join medt in dbContext.MedallaTipo on med.MedallaTipoId equals medt.MedallaTipoId
                                    where ent.ActividadId == idActividad
                                    select new EntregableMedallaDetalle
                                    {
                                        EntregableMedallaID = entm.EntregableMedallaId,
                                        EntregableID = entm.EntregableId,
                                        MedallaId = entm.EntregableId,
                                        MedallaNombre = med.Nombre,
                                        MedallaImagenUrl = med.ImagenUrl,
                                        MedallaDescripcion = med.Descripcion,
                                        MedallaTipoId = medt.MedallaTipoId,
                                        MedallaTipoNombre = medt.Nombre,
                                        MedallaTipoDescripcion = medt.Descripcion,
                                        EntregableMedallaFecha = entm.Fecha
                                    }).OrderByDescending(f => f.EntregableMedallaFecha).FirstOrDefaultAsync();
            medallaList.Add(resultList);
            return medallaList;
        }

        public async Task<ActionResult<IEnumerable<EntregableDetalle>>> GetEntregableDetalle(int idActividad)
        {
            var lastMedal = await GetEntregableMedallaUltimo(idActividad);
            
            var lastEstado = await entregableEstadoDA.GetEntregableEstadoUltimo(idActividad);

            var resultList = await (from ent in dbContext.Entregable
                                    where ent.ActividadId == idActividad
                                    select new EntregableDetalle
                                    {
                                        EntregableId = ent.EntregableId,
                                        ActividadId = ent.ActividadId,
                                        Descripcion = ent.Descripcion,
                                        Comentario = ent.Comentario,
                                        NumeroOrden = ent.NumeroOrden,
                                        EntregableEstadoId = lastEstado.Value.First().EntregableEstadoId,
                                        EntregableDocumentoURL = lastEstado.Value.First().DocumentoUrl,
                                        EstadoFecha = lastEstado.Value.First().Fecha,
                                        ComentarioAlumno = lastEstado.Value.First().ComentarioAlumno,
                                        ComentarioAsesor = lastEstado.Value.First().ComentarioAsesor,
                                        EntregableEstado = lastEstado.Value.First().Estado,
                                        MedallaId = lastMedal.Value.First().MedallaId,
                                        MedallaNombre = lastMedal.Value.First().MedallaNombre,
                                        MedallaImagenURL = lastMedal.Value.First().MedallaImagenUrl
                                    }).ToListAsync();

            return resultList;

        }
    }
}
