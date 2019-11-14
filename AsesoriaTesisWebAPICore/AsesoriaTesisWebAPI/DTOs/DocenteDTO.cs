using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class DocenteDTO
    {
        public DocenteDTO()
        {
            EspecialidaddocenteRelacional = new HashSet<EspecialidaddocenteDTO>();
        }

        public int DocenteId { get; set; }
        public int EscuelaId { get; set; }
        public string Titulo { get; set; }

        public EntidadDTO DocenteNavigationRelacional { get; set; }
        public EscuelaDTO EscuelaRelacional { get; set; }
        public AsesorDTO AsesorRelacional { get; set; }
        public ICollection<EspecialidaddocenteDTO> EspecialidaddocenteRelacional { get; set; }
    }
}
