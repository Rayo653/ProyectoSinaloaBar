using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class ProveedorConfig : IEntityTypeConfiguration<Proveedor>
    {
        public void Configure(EntityTypeBuilder<Proveedor> builder)
        {
            builder.ToTable("Proveedores");

            builder.HasKey(c => c.IdProveedor);

            //builder.HasOne(c => c.Persona)
            //       .WithOne()
            //       .HasForeignKey<Proveedor>(c => c.IdPersona);

        }
    }
}
