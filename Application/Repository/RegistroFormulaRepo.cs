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
    public class RegistroFormulaRepo : GenericRepo<RegistroFormula>, IRegistroFormula
    {
        protected readonly DbAppContext _context;

        public RegistroFormulaRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<RegistroFormula>> GetAllAsync()
        {
            return await _context.RegistroFormulas
                .Include(p => p.Formula)
                .ToListAsync();
        }

        public override async Task<RegistroFormula> GetByIdAsync(int id)
        {
            return await _context.RegistroFormulas
            .Include(p => p.Formula)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}