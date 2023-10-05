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
    public class FarmaceuticoRepo : GenericRepo<Farmaceutico>, IFarmaceutico
    {
        protected readonly DbAppContext _context;

        public FarmaceuticoRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Farmaceutico>> GetAllAsync()
        {
            return await _context.Farmaceuticos
                .Include(p => p.Genero)
                .Include(p => p.TipoDocumento)
                .Include(p => p.TipoPersona)
                .Include(p => p.Cargo)
                .Include(p => p.Direccion)
                .Include(p => p.User)
                .Include(p => p.Contacto)
                .ToListAsync();
        }

        public override async Task<Farmaceutico> GetByIdAsync(int id)
        {
            return await _context.Farmaceuticos
            .Include(p => p.Genero)
            .Include(p => p.TipoDocumento)
            .Include(p => p.TipoPersona)
            .Include(p => p.Cargo)
            .Include(p => p.Direccion)
            .Include(p => p.User)
            .Include(p => p.Contacto)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}