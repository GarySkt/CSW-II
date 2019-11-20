using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class EntregableEstado
    {
        public EntregableEstado()
        {
            EntregableHistoria = new HashSet<EntregableHistoria>();
        }

        public int EntregableEstadoId { get; set; }
        public string DocumentoUrl { get; set; }
        public DateTime Fecha { get; set; }
        public string ComentarioAlumno { get; set; }
        public string ComentarioDocente { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<EntregableHistoria> EntregableHistoria { get; set; }
    }
}
