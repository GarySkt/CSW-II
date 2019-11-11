using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Especialidaddocente
    {
        public int EspecialidadDocenteId { get; set; }
        public int DocenteId { get; set; }
        public int EspecialidadId { get; set; }

        public virtual Docente Docente { get; set; }
        public virtual Especialidad Especialidad { get; set; }
    }
}
