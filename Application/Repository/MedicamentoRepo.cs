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
    public class MedicamentoRepo : GenericRepo<Medicamento>, IMedicamento
    {
        protected readonly DbAppContext _context;

        public MedicamentoRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Medicamento>> GetAllAsync()
        {
            return await _context.Medicamentos
                .Include(p => p.Marca)
                .Include(p => p.Categoria)
                .Include(p => p.TipoPresentacion)
                .ToListAsync();
        }

        public override async Task<Medicamento> GetByIdAsync(int id)
        {
            return await _context.Medicamentos
            .Include(p => p.Marca)
            .Include(p => p.Categoria)
            .Include(p => p.TipoPresentacion)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}