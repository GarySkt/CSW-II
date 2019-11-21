using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.CustomModels
{
    public class EntidadAlumno
    {
        public int AlumnoID { get; set; }
        public int CreditoAprobado { get; set; }
        public int EntidadID { get; set; }
        public int RolID { get; set; }        
        public int EntidadActivo { get; set; }
        public string PersonaNombre { get; set; }
        public string PersonaApellido { get; set; }
        public int EscuelaID { get; set; }
        public string EscuelaNombre { get; set; }
        public int FacultadID { get; set; }

    }
}
