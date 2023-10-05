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
    public class CompraProveedorRepo : GenericRepo<CompraProveedor>, ICompraProveedor
    {
        protected readonly DbAppContext _context;

        public CompraProveedorRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<CompraProveedor>> GetAllAsync()
        {
            return await _context.CompraProveedores
                .Include(p => p.Medicamentos)
                .Include(p => p.Proveedor)
                .Include(p => p.Farmaceutico)
                .ToListAsync();
        }

        public override async Task<CompraProveedor> GetByIdAsync(int id)
        {
            return await _context.CompraProveedores
            .Include(p => p.Medicamentos)
            .Include(p => p.Proveedor)
            .Include(p => p.Farmaceutico)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}