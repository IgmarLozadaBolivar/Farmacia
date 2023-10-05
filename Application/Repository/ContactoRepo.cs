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
    public class ContactoRepo : GenericRepo<Contacto>, IContacto
    {
        protected readonly DbAppContext _context;

        public ContactoRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Contacto>> GetAllAsync()
        {
            return await _context.Contactos
                .Include(p => p.TipoContacto)
                .ToListAsync();
        }

        public override async Task<Contacto> GetByIdAsync(int id)
        {
            return await _context.Contactos
            .Include(p => p.TipoContacto)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}