using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class DepartamentoConfiguration : IEntityTypeConfiguration<Departamento>
    {
        public void Configure(EntityTypeBuilder<Departamento> builder)
        {
            builder.ToTable("Departamento");

            builder.HasKey(d => d.Id);

            builder.Property(d => d.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(d => d.Nombre)
                .IsRequired()
                .HasColumnName("Nombre")
                .HasComment("Nombre del departamento")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.HasOne(p => p.Pais)
                .WithMany(p => p.Departamentos)
                .HasForeignKey(p => p.IdPaisFK);
        }
    }
}