using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class EncargadoBarraConfig : IEntityTypeConfiguration<EncargadoBarra>
    {

        public void Configure(EntityTypeBuilder<EncargadoBarra> builder)
        {

            builder.ToTable("EncargadosBarra");

            builder.HasKey(c => c.IdEncargado);

            //builder.HasOne(c => c.Persona)
            //       .WithOne()
            //       .HasForeignKey<EncargadoBarra>(c => c.IdPersona);
        }
    }
}
