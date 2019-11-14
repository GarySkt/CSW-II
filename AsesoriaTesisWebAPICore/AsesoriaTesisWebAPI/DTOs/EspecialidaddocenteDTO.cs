using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class EspecialidaddocenteDTO
    {
        public int EspecialidadDocenteId { get; set; }
        public int DocenteId { get; set; }
        public int EspecialidadId { get; set; }

        public DocenteDTO DocenteRelacional { get; set; }
        public EspecialidadDTO EspecialidadRelacional { get; set; }
    }
}
