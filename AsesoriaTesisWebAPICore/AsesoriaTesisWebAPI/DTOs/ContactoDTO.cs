using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.DTOs
{
    public class ContactoDTO
    {
        public int EntidadId { get; set; }
        public string Telefono { get; set; }
        public string CorreoPersonal { get; set; }
        public string CorreoInstitucional { get; set; }
        public string Direccion { get; set; }

        public virtual PersonaDTO EntidadRelacional { get; set; }
    }
}
