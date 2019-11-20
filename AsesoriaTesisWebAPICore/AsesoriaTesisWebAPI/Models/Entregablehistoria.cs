using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class EntregableHistoria
    {
        public int EntregableHistoriaId { get; set; }
        public int EntregableEstadoId { get; set; }
        public int EntregableId { get; set; }

        public virtual Entregable Entregable { get; set; }
        public virtual EntregableEstado EntregableEstado { get; set; }
    }
}
