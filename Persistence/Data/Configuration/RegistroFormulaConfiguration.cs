using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class RegistroFormulaConfiguration : IEntityTypeConfiguration<RegistroFormula>
    {
        public void Configure(EntityTypeBuilder<RegistroFormula> builder)
        {
            builder.ToTable("Registro Formula");

            builder.HasKey(rf => rf.Id);

            builder.Property(tc => tc.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(tc => tc.FechaRegistros)
                .IsRequired()
                .HasColumnName("FechaRegistro")
                .HasComment("Fecha de registro de formulas x dia")
                .HasColumnType("datetime");

            builder.HasOne(p => p.Formula)
                .WithMany(p => p.RegistroFormulas)
                .HasForeignKey(p => p.IdForFK);
        }
    }
}