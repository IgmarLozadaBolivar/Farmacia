using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class FormulaConfiguration : IEntityTypeConfiguration<Formula>
    {
        public void Configure(EntityTypeBuilder<Formula> builder)
        {
            builder.ToTable("Formula");

            builder.HasKey(f => f.Id);

            builder.Property(f => f.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(f => f.FechaCreacion)
                .IsRequired()
                .HasColumnName("FechaCreacion")
                .HasComment("Fecha de creacion de la formula")
                .HasColumnType("datetime");

            builder.Property(f => f.FechaExpiracion)
                .IsRequired()
                .HasColumnName("FechaExpiracion")
                .HasComment("Fecha de expiracion de la formula")
                .HasColumnType("datetime");

            builder.Property(f => f.Descripcion)
                .IsRequired()
                .HasColumnName("Descripcion")
                .HasComment("Descripcion de la formula")
                .HasColumnType("varchar(100)")
                .HasMaxLength(100);

            builder.HasOne(p => p.Doctor)
                .WithMany(p => p.Formulas)
                .HasForeignKey(p => p.IdDocFK);

            builder.HasOne(p => p.Paciente)
                .WithMany(p => p.Formulas)
                .HasForeignKey(p => p.IdPacFK);
        }
    }
}