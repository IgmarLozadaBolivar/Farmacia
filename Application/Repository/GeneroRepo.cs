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
    public class GeneroRepo : GenericRepo<Genero>, IGenero
    {
        protected readonly DbAppContext _context;

        public GeneroRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Genero>> GetAllAsync()
        {
            return await _context.Generos
                .Include(p => p.Farmaceuticos)
                .Include(p => p.Pacientes)
                .Include(p => p.Proveedores)
                .Include(p => p.Doctores)
                .ToListAsync();
        }

        public override async Task<Genero> GetByIdAsync(int id)
        {
            return await _context.Generos
            .Include(p => p.Farmaceuticos)
            .Include(p => p.Pacientes)
            .Include(p => p.Proveedores)
            .Include(p => p.Doctores)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}