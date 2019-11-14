using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class AccesoDTO
    {
        public int EntidadId { get; set; }
        public string CodigoInstitucional { get; set; }
        public string Pass { get; set; }

        public PersonaDTO EntidadRelacional { get; set; }
    }
}
