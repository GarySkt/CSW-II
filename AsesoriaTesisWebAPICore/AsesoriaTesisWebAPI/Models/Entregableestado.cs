using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Entregableestado
    {
        public Entregableestado()
        {
            Entregablehistoria = new HashSet<Entregablehistoria>();
        }

        public int EntregableEstadoId { get; set; }
        public string DocumentoUrl { get; set; }
        public DateTime Fecha { get; set; }
        public string ComentarioAlumno { get; set; }
        public string ComentarioDocente { get; set; }
        public int Estado { get; set; }

        public virtual ICollection<Entregablehistoria> Entregablehistoria { get; set; }
    }
}
