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
    public class DoctorRepo : GenericRepo<Doctor>, IDoctor
    {
        protected readonly DbAppContext _context;

        public DoctorRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Doctor>> GetAllAsync()
        {
            return await _context.Doctores
                .Include(p => p.Especializacion)
                .Include(p => p.Genero)
                .Include(p => p.TipoDocumento)
                .Include(p => p.TipoPersona)
                .Include(p => p.Direccion)
                .Include(p => p.Contacto)
                .ToListAsync();
        }

        public override async Task<Doctor> GetByIdAsync(int id)
        {
            return await _context.Doctores
            .Include(p => p.Especializacion)
            .Include(p => p.Genero)
            .Include(p => p.TipoDocumento)
            .Include(p => p.TipoPersona)
            .Include(p => p.Direccion)
            .Include(p => p.Contacto)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}