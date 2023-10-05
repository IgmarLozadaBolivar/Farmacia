using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUnitOfWork
    {
        IPais Pais { get; }
        IDepartamento Departamento { get; }
        ICiudad Ciudad { get; }
        IDireccion Direccion { get; }
        IMarca Marca { get; }
        ICategoria Categoria { get; }
        ITipoPresentacion TipoPresentacion { get; }
        IMedicamento Medicamento { get; }
        ITipoContacto TipoContacto { get; }
        ITipoDocumento TipoDocumento { get; }
        ITipoPersona TipoPersona { get; }
        IContacto Contacto { get; }
        IGenero Genero { get; }
        ICargo Cargo { get; }
        ICompraProveedor CompraProveedor { get; }
        IProveedor Proveedor { get; }
        IFarmaceutico Farmaceutico { get; }
        IEspecializacion Especializacion { get; }
        IDoctor Doctor { get; }
        IPaciente Paciente { get; }
        IFactura Factura { get; }
        IFormula Formula { get; }
        IRegistroFormula RegistroFormula { get; }
        IRol Rol { get; }
        IUser User { get; }
        Task<int> SaveAsync();
    }
}