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
    public class PacienteRepo : GenericRepo<Paciente>, IPaciente
    {
        protected readonly DbAppContext _context;

        public PacienteRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<Paciente>> GetAllAsync()
        {
            return await _context.Pacientes
                .Include(p => p.TipoDocumento)
                .Include(p => p.TipoPersona)
                .Include(p => p.Genero)
                .Include(p => p.Direccion)
                .ToListAsync();
        }

        public override async Task<Paciente> GetByIdAsync(int id)
        {
            return await _context.Pacientes
            .Include(p => p.TipoDocumento)
            .Include(p => p.TipoPersona)
            .Include(p => p.Genero)
            .Include(p => p.Direccion)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}