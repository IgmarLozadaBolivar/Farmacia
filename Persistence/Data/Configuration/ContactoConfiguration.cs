using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class ContactoConfiguration : IEntityTypeConfiguration<Contacto>
    {
        public void Configure(EntityTypeBuilder<Contacto> builder)
        {
            builder.ToTable("Contacto");

            builder.HasKey(c => c.Id);

            builder.Property(c => c.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(c => c.Numero)
                .IsRequired()
                .HasColumnName("Numero")
                .HasComment("Numero de contacto")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.HasOne(p => p.TipoContacto)
                .WithMany(p => p.Contactos)
                .HasForeignKey(p => p.IdTipoConFK);
        }
    }
}