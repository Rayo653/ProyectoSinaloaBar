using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class AdministradorConfig : IEntityTypeConfiguration<Administrador>
    {
        public void Configure(EntityTypeBuilder<Administrador> builder)
        {
            builder.ToTable("Administradores");

            builder.HasKey(c => c.IdAdministrador);

            //builder.HasOne(c => c.Persona)
            //       .WithOne()
            //       .HasForeignKey<Administrador>(c => c.IdPersona);
        }
    }
}
