using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class RolConfig:IEntityTypeConfiguration<Rol>
    {


        public void Configure(EntityTypeBuilder<Rol>builder)
        {


            builder.ToTable("Roles");
            builder.HasKey(c=> c.IdRol);
            builder.Property(p => p.IdRol).ValueGeneratedOnAdd();


            builder.Property(p => p.Nombre)
           .HasMaxLength(20)
           .IsRequired();

            builder.Property(p => p.Estado)
               .IsRequired();

        }

    }
}
