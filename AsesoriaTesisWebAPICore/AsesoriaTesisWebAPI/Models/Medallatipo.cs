﻿using System;
using System.Collections.Generic;

namespace AsesoriaTesisWebAPI.Models
{
    public partial class MedallaTipo
    {
        public MedallaTipo()
        {
            Medalla = new HashSet<Medalla>();
        }

        public int MedallaTipoId { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }

        public virtual ICollection<Medalla> Medalla { get; set; }
    }
}
