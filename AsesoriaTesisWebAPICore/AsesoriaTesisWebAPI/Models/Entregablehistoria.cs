using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Entregablehistoria
    {
        public int EntregableHistoriaId { get; set; }
        public int EntregableEstadoId { get; set; }
        public int EntregableId { get; set; }

        public virtual Entregable Entregable { get; set; }
        public virtual Entregableestado EntregableEstado { get; set; }
    }
}
