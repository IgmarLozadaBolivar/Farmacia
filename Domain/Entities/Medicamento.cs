using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Medicamento : BaseEntity
    {
        public string Nombre { get; set; }
        public decimal Precio { get; set; }
        public int Stock { get; set; }
        public DateTime FechaVencimiento { get; set; }
        public string Descripcion { get; set; }
        public int IdCatFK { get; set; }
        public Categoria Categoria { get; set; }
        public int IdMarFK { get; set; }
        public Marca Marca { get; set; }
        public bool Disponibilidad { get; set; }
        public int IdTipoPreFK { get; set; }
        public TipoPresentacion TipoPresentacion { get; set; }
        public ICollection<CompraProveedor> CompraProveedores { get; set; }
        public ICollection<Factura> Facturas{ get; set; }
    }
}