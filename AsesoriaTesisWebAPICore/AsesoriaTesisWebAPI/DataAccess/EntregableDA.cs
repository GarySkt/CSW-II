using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using AsesoriaTesisWebAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using AsesoriaTesisWebAPI.CustomModels;
using System;

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
        public async Task<ActionResult<IEnumerable<EntregableMedallaDetalle>>> GetEntregableMedallaUltimo(int idEntregable)
        {
            List<EntregableMedallaDetalle> medallaList = new List<EntregableMedallaDetalle>();
            var resultList = await (from entm in dbContext.EntregableMedalla                                    
                                    join ent in dbContext.Entregable on entm.EntregableId equals ent.EntregableId
                                    join med in dbContext.Medalla on entm.MedallaId equals med.MedallaId
                                    join medt in dbContext.MedallaTipo on med.MedallaTipoId equals medt.MedallaTipoId
                                    where ent.EntregableId == idEntregable
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

            List<EntregableDetalle> listaEntregable = new List<EntregableDetalle>();

            //Se obtienen los entregables
            var resultList = await (from ent in dbContext.Entregable
                                    where ent.ActividadId == idActividad
                                    select new EntregableDetalle
                                    {
                                        EntregableId = ent.EntregableId,
                                        ActividadId = ent.ActividadId,
                                        Descripcion = ent.Descripcion,
                                        Comentario = ent.Comentario,
                                        NumeroOrden = ent.NumeroOrden                                        
                                    }).ToListAsync();

            foreach (var list in resultList)
            {
                //Se obtienen las ultimas actualizaciones de cada entregable y se agrega a la lista 
                var lastEstado = await entregableEstadoDA.GetEntregableEstadoUltimo(list.EntregableId);
                var lastMedal = await GetEntregableMedallaUltimo(list.EntregableId);

                EntregableDetalle entregableDetalle = new EntregableDetalle()
                {                    
                    EntregableId = list.EntregableId,
                    ActividadId = list.ActividadId,
                    Descripcion = list.Descripcion,
                    Comentario = list.Comentario,
                    NumeroOrden = list.NumeroOrden,
                    EntregableEstadoId = lastEstado.Value.First() != null ? lastEstado.Value.First().EntregableEstadoId : 0,
                    EntregableDocumentoURL = lastEstado.Value.First() != null ? lastEstado.Value.First().DocumentoUrl : "Sin especificar documento",
                    EstadoFecha = lastEstado.Value.First() != null ? lastEstado.Value.First().Fecha : Convert.ToDateTime("1500-05-05"),
                    ComentarioAlumno = lastEstado.Value.First() != null ? lastEstado.Value.First().ComentarioAlumno : "Sin comentarios",
                    ComentarioAsesor = lastEstado.Value.First() != null ? lastEstado.Value.First().ComentarioAsesor: "Sin comentarios",
                    EntregableEstado = (lastEstado.Value.First() != null) ? ((lastEstado.Value.First().Estado == 1) ? "Enviado" : ((lastEstado.Value.First().Estado == 2) ? "Corregir" : "Aprobado")) : "Sin novedades",
                    MedallaId = lastMedal.Value.First() != null ? lastMedal.Value.First().MedallaId : 0,
                    MedallaNombre = lastMedal.Value.First() != null ? lastMedal.Value.First().MedallaNombre : "No se asignaron medallas",
                    MedallaImagenURL = lastMedal.Value.First() != null ? lastMedal.Value.First().MedallaImagenUrl : "No se asignaron medallas"
                };

                listaEntregable.Add(entregableDetalle);
            }

            return listaEntregable;

        }
    }
}
