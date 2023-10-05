using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class RegistroFormula : BaseEntity
    {
        public DateTime FechaRegistros { get; set; }
        public int IdForFK { get; set; }
        public Formula Formula { get; set; }
    }
}