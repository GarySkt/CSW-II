using AsesoriaTesisWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class EntregableEstadoDA
    {
        private readonly TutoriaContext dbContext;

        public EntregableEstadoDA()
        {
            dbContext = new TutoriaContext();
        }

        public async Task<ActionResult<IEnumerable<EntregableEstado>>> GetEntregableEstadoUltimo(int idEntregable)
        {
            List<EntregableEstado> estadoList = new List<EntregableEstado>();
            var resultList = await (from enth in dbContext.EntregableHistoria
                                    join ente in dbContext.EntregableEstado on enth.EntregableEstadoId equals ente.EntregableEstadoId
                                    join ent in dbContext.Entregable on enth.EntregableId equals ent.EntregableId
                                    where ent.EntregableId == idEntregable
                                    select new EntregableEstado
                                    {
                                        EntregableEstadoId = enth.EntregableEstadoId,
                                        DocumentoUrl = ente.DocumentoUrl,
                                        Fecha = ente.Fecha,
                                        ComentarioAlumno = ente.ComentarioAlumno,
                                        ComentarioAsesor = ente.ComentarioAsesor,
                                        Estado = ente.Estado
                                    }).OrderByDescending(f => f.Fecha).FirstOrDefaultAsync();
            estadoList.Add(resultList);
            return estadoList;

        }

        
    }
}
