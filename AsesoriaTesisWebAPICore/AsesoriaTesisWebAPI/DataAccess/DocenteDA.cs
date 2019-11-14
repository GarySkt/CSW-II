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

        //Metodo
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
    }
}
