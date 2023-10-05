using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using Persistence;

namespace Application.Repository
{
    public class ProveedorRepo : GenericRepo<Proveedor>, IProveedor
    {
        protected readonly DbAppContext _context;

        public ProveedorRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Proveedor>> GetAllAsync()
        {
            return await _context.Proveedores
                .Include(p => p.TipoDocumento)
                .Include(p => p.TipoPersona)
                .Include(p => p.Genero)
                .Include(p => p.Direccion)
                .Include(p => p.Contacto)
                .ToListAsync();
        }

        public override async Task<Proveedor> GetByIdAsync(int id)
        {
            return await _context.Proveedores
            .Include(p => p.TipoDocumento)
            .Include(p => p.TipoPersona)
            .Include(p => p.Genero)
            .Include(p => p.Direccion)
            .Include(p => p.Contacto)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}