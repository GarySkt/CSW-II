using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EntregablehistoriaDTO
    {
        public int EntregableHistoriaId { get; set; }
        public int EntregableEstadoId { get; set; }
        public int EntregableId { get; set; }

        public virtual EntregableDTO EntregableRelacional { get; set; }
        public virtual EntregableestadoDTO EntregableEstadoRelacional { get; set; }
    }
}
