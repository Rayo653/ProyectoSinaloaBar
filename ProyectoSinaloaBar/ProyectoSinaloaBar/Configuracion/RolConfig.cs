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

        }

    }
}
