using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class CicloDTO
    {
        public CicloDTO()
        {
            EntidadcicloRelacional = new HashSet<EntidadcicloDTO>();
        }

        public int CicloId { get; set; }
        public string Nombre { get; set; }
        public int Anio { get; set; }

        public ICollection<EntidadcicloDTO> EntidadcicloRelacional { get; set; }
    }
}
