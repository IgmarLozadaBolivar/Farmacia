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
    public class EspecializacionRepo : GenericRepo<Especializacion>, IEspecializacion
    {
        protected readonly DbAppContext _context;

        public EspecializacionRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Especializacion>> GetAllAsync()
        {
            return await _context.Especializaciones
                .Include(p => p.Doctores)
                .ToListAsync();
        }

        public override async Task<Especializacion> GetByIdAsync(int id)
        {
            return await _context.Especializaciones
            .Include(p => p.Doctores)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}