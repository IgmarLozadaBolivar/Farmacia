using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Paciente : BaseEntity
    {
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public DateTime FechaNac { get; set; }
        public int IdGenFK { get; set; }
        public Genero Genero { get; set; }
        public int Edad { get; set; }
        public int IdTipoDocFK { get; set; }
        public TipoDocumento TipoDocumento { get; set; }
        public int IdTipoPerFK { get; set; }
        public TipoPersona TipoPersona { get; set; }
        public int IdDirFK { get; set; }
        public Direccion Direccion { get; set; }
        public int IdConFK { get; set; }
        public Contacto Contacto { get; set; }
        public ICollection<Formula> Formulas { get; set; }
        public ICollection<Factura> Facturas { get; set; }
    }
}