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
    public class TipoDocumentoRepo : GenericRepo<TipoDocumento>, ITipoDocumento
    {
        protected readonly DbAppContext _context;

        public TipoDocumentoRepo(DbAppContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<IEnumerable<TipoDocumento>> GetAllAsync()
        {
            return await _context.TipoDocumentos
                .Include(p => p.Farmaceuticos)
                .Include(p => p.Pacientes)
                .Include(p => p.Proveedores)
                .Include(p => p.Doctores)
                .ToListAsync();
        }

        public override async Task<TipoDocumento> GetByIdAsync(int id)
        {
            return await _context.TipoDocumentos
            .Include(p => p.Farmaceuticos)
            .Include(p => p.Pacientes)
            .Include(p => p.Proveedores)
            .Include(p => p.Doctores)
            .FirstOrDefaultAsync(p => p.Id == id);
        }
    }
}