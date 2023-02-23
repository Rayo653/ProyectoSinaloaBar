using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class PersonaConfig : IEntityTypeConfiguration<Persona>
    {
        public void Configure(EntityTypeBuilder<Persona> builder)
        {
            builder.ToTable("Personas");

            builder.HasKey(c => c.IdPersona);

            builder.Property(c => c.NumDocumento).IsRequired();
            builder.Property(c => c.NumDocumento).HasMaxLength(20);

            builder.Property(c => c.Contrasena).IsRequired();
            builder.Property(c => c.Contrasena).HasMaxLength(20);

            builder.Property(c => c.PNombre).IsRequired();
            builder.Property(c => c.PNombre).HasMaxLength(20);

            builder.Property(c => c.PApellido).IsRequired();
            builder.Property(c => c.PApellido).HasMaxLength(20);

            builder.Property(c => c.SApellido).HasMaxLength(20);

            builder.Property(c => c.Direccion).HasMaxLength(32);

            builder.Property(c => c.Telefono).HasMaxLength(15);

            builder.Property(c => c.Sexo).HasMaxLength(9);

            builder.Property(c => c.Correo).HasMaxLength(100);

            builder.Property(c => c.Estado).HasDefaultValue(false);

            builder.HasOne(c => c.TipoDocumento)
                   .WithMany()
                   .HasForeignKey(c => c.FkTdoc);

            builder.HasOne(c => c.Rol)
                   .WithMany()
                   .HasForeignKey(c => c.FkRol);
        }
    }
}
