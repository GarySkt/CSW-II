using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class RolDTO
    {
        public RolDTO()
        {
            EntidadRelacional = new HashSet<EntidadDTO>();
        }

        public int RolId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<EntidadDTO> EntidadRelacional { get; set; }
    }
}
