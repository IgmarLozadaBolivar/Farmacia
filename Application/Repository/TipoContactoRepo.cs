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
    public class TipoContactoRepo : GenericRepo<TipoContacto>, ITipoContacto
    {
        protected readonly DbAppContext _context;

        public TipoContactoRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<TipoContacto>> GetAllAsync()
        {
            return await _context.TipoContactos
                .Include(p => p.Contactos)
                .ToListAsync();
        }

        public override async Task<TipoContacto> GetByIdAsync(int id)
        {
            return await _context.TipoContactos
            .Include(p => p.Contactos)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}