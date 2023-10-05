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
    public class RolRepo : GenericRepo<Rol>, IRol
    {
        protected readonly DbAppContext _context;

        public RolRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Rol>> GetAllAsync()
        {
            return await _context.Rols
                .Include(p => p.Users)
                .ToListAsync();
        }

        public override async Task<Rol> GetByIdAsync(int id)
        {
            return await _context.Rols
            .Include(p => p.Users)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}