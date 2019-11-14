using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class AlumnoDTO
    {
        public AlumnoDTO()
        {
            ActividadRelacionaL = new HashSet<ActividadDTO>();
        }
        public int AlumnoId { get; set; }
        public int EscuelaId { get; set; }
        public int CreditoAprobado { get; set; }

        public EntidadDTO AlumnoNavigationRelacionaL { get; set; }
        public EscuelaDTO EscuelaRelacionaL { get; set; }
        public ICollection<ActividadDTO> ActividadRelacionaL { get; set; }
    }
}
