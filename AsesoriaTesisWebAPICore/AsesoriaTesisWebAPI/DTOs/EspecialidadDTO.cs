using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EspecialidadDTO
    {
        public EspecialidadDTO()
        {
            EspecialidaddocenteRelacional = new HashSet<EspecialidaddocenteDTO>();
        }

        public int EspecialidadId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public ICollection<EspecialidaddocenteDTO> EspecialidaddocenteRelacional { get; set; }
    }
}
