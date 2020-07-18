using System;
using System.Collections.Generic;
using System.Text;

namespace VendinhaEsquina.Core.Entities
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public DateTime CriadoEm { get; set; }
        public DateTime? ModificadoEm { get; set; }
        public DateTime? DeletadoEm { get; set; }
    }
}
