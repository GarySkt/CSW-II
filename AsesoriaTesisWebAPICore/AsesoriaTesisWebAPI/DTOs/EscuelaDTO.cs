using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EscuelaDTO
    {
        public EscuelaDTO()
        {
            AlumnoRelacional = new HashSet<AlumnoDTO>();
            DocenteRelacional = new HashSet<DocenteDTO>();
        }

        public int EscuelaId { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public int FacultadId { get; set; }

        public FacultadDTO FacultadRelacional { get; set; }
        public ICollection<AlumnoDTO> AlumnoRelacional { get; set; }
        public ICollection<DocenteDTO> DocenteRelacional { get; set; }
    }
}
