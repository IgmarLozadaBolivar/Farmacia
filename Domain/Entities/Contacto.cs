using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Contacto : BaseEntity
    {
        public string Numero { get; set; }
        public int IdTipoConFK { get; set; }
        public TipoContacto TipoContacto { get; set; }
        public ICollection<Doctor> Doctores { get; set; }
        public ICollection<Paciente> Pacientes { get; set; }
        public ICollection<Farmaceutico> Farmaceuticos { get; set; }
        public ICollection<Proveedor> Proveedores { get; set; }
    }
}