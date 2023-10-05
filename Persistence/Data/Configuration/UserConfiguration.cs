using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Data.Configuration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");

            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id)
                .IsRequired()
                .HasMaxLength(3);

            builder.Property(u => u.Username)
                .IsRequired()
                .HasColumnName("Username")
                .HasComment("Nombre de usuario")
                .HasColumnType("varchar(50)")
                .HasMaxLength(50);

            builder.Property(u => u.Password)
                .IsRequired()
                .HasColumnName("Password")
                .HasComment("contraseña del usuario")
                .HasColumnType("varchar(255)")
                .HasMaxLength(255);

            builder.HasOne(p => p.Rol)
                .WithMany(p => p.Users)
                .HasForeignKey(p => p.IdRolFK);
        }
    }
}