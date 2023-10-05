using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Formula : BaseEntity
    {
        public int IdDocFK { get; set; }
        public Doctor Doctor { get; set; }
        public int IdPacFK { get; set; }
        public Paciente Paciente { get; set; }
        public DateTime FechaCreacion { get; set; }
        public DateTime FechaExpiracion { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Factura> Facturas { get; set; }
        public ICollection<RegistroFormula> RegistroFormulas { get; set; }
    }
}