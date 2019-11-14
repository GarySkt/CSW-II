using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class PersonaDTO
    {
        public int PersonaID { get; set; }
        public int EntidadId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public DateTime FechaNacimiento { get; set; }
        public string Dni { get; set; }

        public EntidadDTO EntidadRelacional { get; set; }
        public AccesoDTO AccesoRelacional { get; set; }
        public ContactoDTO ContactoRelacional { get; set; }
    }
}
