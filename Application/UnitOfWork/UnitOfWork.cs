using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Application.Repository;
using Domain.Entities;
using Domain.Interfaces;
using Persistence;

namespace Application.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork, IDisposable
    {
        private readonly DbAppContext context;
        private PaisRepo _paises;
        private DepartamentoRepo _departamentos;
        private CiudadRepo _ciudades;
        private DireccionRepo _direcciones;
        private MarcaRepo _marcas;
        private CategoriaRepo _categorias;
        private TipoPresentacionRepo _tipoPresentaciones;
        private MedicamentoRepo _medicamentos;
        private GeneroRepo _generos;
        private TipoContactoRepo _tipoContactos;
        private TipoDocumentoRepo _tipoDocumentos;
        private TipoPersonaRepo _tipoPersonas;
        private ContactoRepo _contactos;
        private CompraProveedorRepo _compraProveedores;
        private CargoRepo _cargos;
        private FarmaceuticoRepo _farmaceuticos;
        private PacienteRepo _pacientes;
        private ProveedorRepo _proveedores;
        private EspecializacionRepo _especializaciones;
        private DoctorRepo _doctores;
        private FormulaRepo _formulas;
        private FacturaRepo _facturas;
        private RegistroFormulaRepo _registroFormulas;
        private RolRepo _rols;

        public UnitOfWork(DbAppContext _context)
        {
            context = _context;
        }

        public IPais Pais
        {
            get
            {
                if (_paises == null)
                {
                    _paises = new PaisRepo(context);
                }
                return _paises;
            }
        }

        public IDepartamento Departamento
        {
            get
            {
                if (_departamentos == null)
                {
                    _departamentos = new DepartamentoRepo(context);
                }
                return _departamentos;
            }
        }

        public ICiudad Ciudad
        {
            get
            {
                if (_ciudades == null)
                {
                    _ciudades = new CiudadRepo(context);
                }
                return _ciudades;
            }
        }

        public IDireccion Direccion
        {
            get
            {
                if (_direcciones == null)
                {
                    _direcciones = new DireccionRepo(context);
                }
                return _direcciones;
            }
        }

        public IMarca Marca
        {
            get
            {
                if (_marcas == null)
                {
                    _marcas = new MarcaRepo(context);
                }
                return _marcas;
            }
        }

        public ICategoria Categoria
        {
            get
            {
                if (_categorias == null)
                {
                    _categorias = new CategoriaRepo(context);
                }
                return _categorias;
            }
        }

        public ITipoPresentacion TipoPresentacion
        {
            get
            {
                if (_tipoPresentaciones == null)
                {
                    _tipoPresentaciones = new TipoPresentacionRepo(context);
                }
                return _tipoPresentaciones;
            }
        }

        public IMedicamento Medicamento
        {
            get
            {
                if (_medicamentos == null)
                {
                    _medicamentos = new MedicamentoRepo(context);
                }
                return _medicamentos;
            }
        }

        public IGenero Genero
        {
            get
            {
                if (_generos == null)
                {
                    _generos = new GeneroRepo(context);
                }
                return _generos;
            }
        }

        public ITipoDocumento TipoDocumento
        {
            get
            {
                if (_tipoDocumentos == null)
                {
                    _tipoDocumentos = new TipoDocumentoRepo(context);
                }
                return _tipoDocumentos;
            }
        }

        public ITipoPersona TipoPersona
        {
            get
            {
                if (_tipoPersonas == null)
                {
                    _tipoPersonas = new TipoPersonaRepo(context);
                }
                return _tipoPersonas;
            }
        }

        public ITipoContacto TipoContacto
        {
            get
            {
                if (_tipoContactos == null)
                {
                    _tipoContactos = new TipoContactoRepo(context);
                }
                return _tipoContactos;
            }
        }

        public IContacto Contacto
        {
            get
            {
                if (_contactos == null)
                {
                    _contactos = new ContactoRepo(context);
                }
                return _contactos;
            }
        }

        public ICargo Cargo
        {
            get
            {
                if (_cargos == null)
                {
                    _cargos = new CargoRepo(context);
                }
                return _cargos;
            }
        }

        public IFarmaceutico Farmaceutico
        {
            get
            {
                if (_farmaceuticos == null)
                {
                    _farmaceuticos = new FarmaceuticoRepo(context);
                }
                return _farmaceuticos;
            }
        }

        public IPaciente Paciente
        {
            get
            {
                if (_pacientes == null)
                {
                    _pacientes = new PacienteRepo(context);
                }
                return _pacientes;
            }
        }

        public ICompraProveedor CompraProveedor
        {
            get
            {
                if (_compraProveedores == null)
                {
                    _compraProveedores = new CompraProveedorRepo(context);
                }
                return _compraProveedores;
            }
        }

        public IProveedor Proveedor
        {
            get
            {
                if (_proveedores == null)
                {
                    _proveedores = new ProveedorRepo(context);
                }
                return _proveedores;
            }
        }

        public IEspecializacion Especializacion
        {
            get
            {
                if (_especializaciones == null)
                {
                    _especializaciones = new EspecializacionRepo(context);
                }
                return _especializaciones;
            }
        }

        public IDoctor Doctor
        {
            get
            {
                if (_doctores == null)
                {
                    _doctores = new DoctorRepo(context);
                }
                return _doctores;
            }
        }

        public IFactura Factura
        {
            get
            {
                if (_facturas == null)
                {
                    _facturas = new FacturaRepo(context);
                }
                return _facturas;
            }
        }

        public IFormula Formula
        {
            get
            {
                if (_formulas == null)
                {
                    _formulas = new FormulaRepo(context);
                }
                return _formulas;
            }
        }

        public IRegistroFormula RegistroFormula
        {
            get
            {
                if (_registroFormulas == null)
                {
                    _registroFormulas = new RegistroFormulaRepo(context);
                }
                return _registroFormulas;
            }
        }

        public IRol Rol
        {
            get
            {
                if (_rols == null)
                {
                    _rols = new RolRepo(context);
                }
                return _rols;
            }
        }

        public void Dispose()
        {
            context.Dispose();
        }

        public async Task<int> SaveAsync()
        {
            return await context.SaveChangesAsync();
        }
    }

}