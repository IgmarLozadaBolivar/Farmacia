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
    public class MarcaRepo : GenericRepo<Marca>, IMarca
    {
        protected readonly DbAppContext _context;

        public MarcaRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Marca>> GetAllAsync()
        {
            return await _context.Marcas
                .Include(p => p.Medicamentos)
                .ToListAsync();
        }

        public override async Task<Marca> GetByIdAsync(int id)
        {
            return await _context.Marcas
            .Include(p => p.Medicamentos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}