using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class LineaInvestigacionDocente
    {
        public int LineaInvestigacionDocenteId { get; set; }
        public int DocenteId { get; set; }
        public int LineaInvestigacionId { get; set; }

        public virtual Docente Docente { get; set; }
        public virtual LineaInvestigacion LineaInvestigacion { get; set; }
    }
}
