using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Direccion : BaseEntity
    {
        public string Descripcion { get; set; }
        public int IdCiuFK { get; set; }
        public Ciudad Ciudad { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<Farmaceutico> Farmaceuticos { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }
        public ICollection<Doctor> Doctores { get; set; }
    }
}