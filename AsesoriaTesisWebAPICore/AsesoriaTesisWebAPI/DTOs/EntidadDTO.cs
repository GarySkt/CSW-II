using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EntidadDTO
    {
        public EntidadDTO()
        {
            EntidadcicloRelacional = new HashSet<EntidadcicloDTO>();
        }

        public int EntidadId { get; set; }
        public int RolId { get; set; }
        public int EstaActivo { get; set; }

        public RolDTO RolRelacional { get; set; }
        public AlumnoDTO AlumnoRelacional { get; set; }
        public DocenteDTO DocenteRelacional { get; set; }
        public PersonaDTO PersonaRelacional { get; set; }
        public ICollection<EntidadcicloDTO> EntidadcicloRelacional { get; set; }
    }
}
