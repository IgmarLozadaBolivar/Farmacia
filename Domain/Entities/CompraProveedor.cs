using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class CompraProveedor : BaseEntity
    {
        public decimal Precio { get; set; }
        public int Cantidad { get; set; }
        public int IdMedFK { get; set; }
        public Medicamento Medicamentos { get; set; }
        public int IdProvFK { get; set; }
        public Proveedor Proveedor { get; set; }
        public int IdFarFK { get; set; }
        public Farmaceutico Farmaceutico { get; set; }
    }
}