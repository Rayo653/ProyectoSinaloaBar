using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class ClienteConfig : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");

            builder.HasKey(c => c.IdCliente);

            builder.HasOne(c => c.Persona)
                   .WithOne()
                   .HasForeignKey<Cliente>(c => c.IdPersona);
        }
    }
}
