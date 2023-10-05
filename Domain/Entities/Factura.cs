using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Factura : BaseEntity
    {
        public DateTime FechaCreacion { get; set; }
        public string Descripcion { get; set; }
        public decimal Valor { get; set; }
        public string Estado { get; set; }
        public int Cantidad { get; set; }
        public int IdMedFK { get; set; }
        public Medicamento Medicamento { get; set; }
        public int IdFarFK { get; set; }
        public Farmaceutico Farmaceutico { get; set; }
        public int IdPacFK { get; set; }
        public Paciente Paciente { get; set; }
        public int IdForFK { get; set; }
        public Formula Formula { get; set; }
    }
}