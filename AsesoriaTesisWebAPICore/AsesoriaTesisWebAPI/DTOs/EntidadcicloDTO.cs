using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EntidadcicloDTO
    {
        public int EntidadCicloId { get; set; }
        public int EntidadId { get; set; }
        public int CicloId { get; set; }

        public CicloDTO CicloRelacional { get; set; }
        public EntidadDTO EntidadRelacional { get; set; }
    }
}
