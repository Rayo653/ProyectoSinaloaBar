using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProyectoSinaloaBar.Models;

namespace ProyectoSinaloaBar.Configuracion
{
    public class TipoDocumentoConfig : IEntityTypeConfiguration<TipoDocumento>
    {

        public void Configure(EntityTypeBuilder<TipoDocumento> builder)
        {
            builder.ToTable("TipoDocumentos");

            // Configuración de la clave primaria
            builder.HasKey(c => c.IdTdoc);
            builder.Property(p => p.IdTdoc).ValueGeneratedOnAdd();

            // Configuración de la propiedad Tdoc
            builder.Property(p => p.Tdoc)
                   .HasMaxLength(10)
                   .IsRequired();

            // Configuración de la propiedad DescTdoc
            builder.Property(p => p.DescTdoc)
                   .HasMaxLength(30)
                   .IsRequired();

            // Configuración de la propiedad Estado
            builder.Property(p => p.Estado)
                   .HasDefaultValue(false)
                   .IsRequired();
        }



    }
}
