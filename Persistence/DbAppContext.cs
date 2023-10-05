using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class DbAppContext : DbContext
    {
        public DbAppContext(DbContextOptions<DbAppContext> options) : base(options)
        { }

        public DbSet<Pais> Paises { get; set; }
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Ciudad> Ciudades { get; set; }
        public DbSet<Direccion> Direcciones { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Doctor> Doctores { get; set; }
        public DbSet<Farmaceutico> Farmaceuticos { get; set; }
        public DbSet<Proveedor> Proveedores { get; set; }
        public DbSet<TipoDocumento> TipoDocumentos { get; set; }
        public DbSet<TipoPersona> TipoPersonas { get; set; }
        public DbSet<TipoContacto> TipoContactos { get; set; }
        public DbSet<TipoPresentacion> TipoPresentaciones { get; set; }
        public DbSet<Medicamento> Medicamentos { get; set; }
        public DbSet<Formula> Formulas { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Rol> Rols { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<RegistroFormula> RegistroFormulas { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Marca> Marcas { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
        public DbSet<Especializacion> Especializaciones { get; set; }
        public DbSet<CompraProveedor> CompraProveedores { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Contacto> Contactos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }
    }
}