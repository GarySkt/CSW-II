using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class Docente
    {
        public Docente()
        {
            LineaInvestigacionDocente = new HashSet<LineaInvestigacionDocente>();
        }

        public int DocenteId { get; set; }
        public string Titulo { get; set; }

        public virtual Entidad DocenteNavigation { get; set; }
        public virtual Asesor Asesor { get; set; }
        public virtual ICollection<LineaInvestigacionDocente> LineaInvestigacionDocente { get; set; }
    }
}
