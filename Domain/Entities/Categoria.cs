using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Categoria : BaseEntity
    {
        public string Nombre { get; set; }
        public ICollection<Medicamento> Medicamentos { get; set; }
    }
}