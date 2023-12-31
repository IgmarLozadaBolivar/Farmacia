using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cargo : BaseEntity
    {
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public ICollection<Farmaceutico> Farmaceuticos { get; set; }
    }
}