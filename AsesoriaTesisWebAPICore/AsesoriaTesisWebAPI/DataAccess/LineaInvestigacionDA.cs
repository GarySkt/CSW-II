using AsesoriaTesisWebAPI.CustomModels;
using AsesoriaTesisWebAPI.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DataAccess
{
    public class LineaInvestigacionDA
    {
        private readonly TutoriaContext dbContext;

        public LineaInvestigacionDA()
        {
            dbContext = new TutoriaContext();
        }

        public async Task<ActionResult<IEnumerable<LineaAreaInvestigacion>>> GetLineaInvestigacionArea(int idAreaInvestigacion)
        {
            List<LineaAreaInvestigacion> listalineaAreaInvestigacions = new List<LineaAreaInvestigacion>();
            var resultList = await dbContext.LineaInvestigacion
                .Include(e => e.AreaInvestigacion)
                .Where(e => e.AreaInvestigacionId.Equals(idAreaInvestigacion))
                .ToListAsync();

            foreach (var lista in resultList)
            {
                LineaAreaInvestigacion lineaAreaInvestigacion = new LineaAreaInvestigacion()
                {
                    LineaInvestigacionId = lista.LineaInvestigacionId,
                    LineaInvestigacionNombre = lista.Nombre,
                    LineaInvestigacionDescripcion = lista.Descripcion,
                    AreaInvestigacionId = lista.AreaInvestigacion.AreaInvestigacionId,
                    AreaInvestigacionNombre = lista.AreaInvestigacion.Nombre,
                    AreaInvestigacionDescripcion = lista.AreaInvestigacion.Descripcion
                };

                listalineaAreaInvestigacions.Add(lineaAreaInvestigacion);
            }

            return listalineaAreaInvestigacions;

        }

    }
}
