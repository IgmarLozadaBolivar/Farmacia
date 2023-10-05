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
    public class CategoriaRepo : GenericRepo<Categoria>, ICategoria
    {
        protected readonly DbAppContext _context;

        public CategoriaRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Categoria>> GetAllAsync()
        {
            return await _context.Categorias
                .Include(p => p.Medicamentos)
                .ToListAsync();
        }

        public override async Task<Categoria> GetByIdAsync(int id)
        {
            return await _context.Categorias
            .Include(p => p.Medicamentos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}