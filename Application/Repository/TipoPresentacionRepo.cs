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
    public class TipoPresentacionRepo : GenericRepo<TipoPresentacion>, ITipoPresentacion
    {
        protected readonly DbAppContext _context;

        public TipoPresentacionRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<TipoPresentacion>> GetAllAsync()
        {
            return await _context.TipoPresentaciones
                .Include(p => p.Medicamentos)
                .ToListAsync();
        }

        public override async Task<TipoPresentacion> GetByIdAsync(int id)
        {
            return await _context.TipoPresentaciones
            .Include(p => p.Medicamentos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}