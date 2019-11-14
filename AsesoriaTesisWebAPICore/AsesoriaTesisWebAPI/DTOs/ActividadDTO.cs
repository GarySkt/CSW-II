using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class ActividadDTO
    {
        public ActividadDTO()
        {
            EntregableRelacional = new HashSet<EntregableDTO>();
        }
        public int ActividadId { get; set; }
        public int Finalizada { get; set; }
        public int AlumnoId { get; set; }
        public string Titulo { get; set; }
        public string Resumen { get; set; }
        public string Descripcion { get; set; }
        public int AsesorId { get; set; }
        public int ActividadTipoId { get; set; }

        public ActividadtipoDTO ActividadTipoRelacional { get; set; }
        public AlumnoDTO AlumnoRelacional { get; set; }
        public AsesorDTO AsesorRelacional { get; set; }
        public ICollection<EntregableDTO> EntregableRelacional { get; set; }
    }
}
