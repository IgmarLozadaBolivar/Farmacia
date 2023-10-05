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
    public class FacturaRepo : GenericRepo<Factura>, IFactura
    {
        protected readonly DbAppContext _context;

        public FacturaRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Factura>> GetAllAsync()
        {
            return await _context.Facturas
                .Include(p => p.Medicamento)
                .Include(p => p.Farmaceutico)
                .Include(p => p.Paciente)
                .Include(p => p.Formula)
                .ToListAsync();
        }

        public override async Task<Factura> GetByIdAsync(int id)
        {
            return await _context.Facturas
            .Include(p => p.Medicamento)
            .Include(p => p.Farmaceutico)
            .Include(p => p.Paciente)
            .Include(p => p.Formula)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}