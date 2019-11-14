using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class FacultadDTO
    {
        public FacultadDTO()
        {
            EscuelaRelacional = new HashSet<EscuelaDTO>();
        }

        public int FacultadId { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }

        public ICollection<EscuelaDTO> EscuelaRelacional { get; set; }
    }
}
