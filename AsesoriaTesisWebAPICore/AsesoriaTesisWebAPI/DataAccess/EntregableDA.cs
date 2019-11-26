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

        public EntregableDA()
        {
            dbContext = new TutoriaContext();
        }

        //public async Task<ActionResult<IEnumerable<EntregableDetalle>>> GetEntregableDetalleActividad(int idActividad)
        //{

        //    //var resultList = await (from ent in dbContext.Entregable                
        //    //                        join enth in dbContext.EntregableHistoria on ent.EntregableId equals enth.EntregableId
        //    //                        join ente in dbContext.EntregableEstado on enth.EntregableEstadoId equals ente.EntregableEstadoId
        //    //                        join entm in dbContext.EntregableMedalla on ent.EntregableId equals entm.EntregableId
        //    //                        join med in dbContext.Medalla on entm.MedallaId equals med.MedallaId                                    
        //    //                        where ent.ActividadId == idActividad
        //    //                        select new EntregableDetalle
        //    //                        {
        //    //                            DocenteID = d.DocenteId,
        //    //                            DocenteNombre = p.Nombre,
        //    //                            DocenteApellido = p.Apellido,
        //    //                            EscuelaID = e.EscuelaId,
        //    //                            EscuelaNombre = e.Nombre,
        //    //                            LineaInvestigacionID = ed.LineaInvestigacionId
        //    //                        }).ToListAsync();


        //    //return resultList;

        //}
    }
}
