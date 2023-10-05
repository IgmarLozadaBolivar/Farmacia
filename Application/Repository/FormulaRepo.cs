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
    public class FormulaRepo : GenericRepo<Formula>, IFormula
    {
        protected readonly DbAppContext _context;

        public FormulaRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Formula>> GetAllAsync()
        {
            return await _context.Formulas
                .Include(p => p.Doctor)
                .Include(p => p.Paciente)
                .ToListAsync();
        }

        public override async Task<Formula> GetByIdAsync(int id)
        {
            return await _context.Formulas
            .Include(p => p.Doctor)
            .Include(p => p.Paciente)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}