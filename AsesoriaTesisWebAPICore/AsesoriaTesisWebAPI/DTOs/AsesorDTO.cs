using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class AsesorDTO
    {
        public AsesorDTO()
        {
            ActividadRelacionaL = new HashSet<ActividadDTO>();
        }
        public int AsesorId { get; set; }
        public int Disponibilidad { get; set; }

        public DocenteDTO AsesorNavigationRelacionaL { get; set; }
        public ICollection<ActividadDTO> ActividadRelacionaL { get; set; }
    }
}
