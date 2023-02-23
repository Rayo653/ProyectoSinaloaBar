using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using ProyectoSinaloaBar.Configuracion;

namespace ProyectoSinaloaBar.Models
{

    public class ProyectoSinaloaBarContext : DbContext
        { 
    public ProyectoSinaloaBarContext(DbContextOptions<ProyectoSinaloaBarContext> options)
        : base(options)
    {

    }

        public DbSet<Rol> Roles { get; set; }
        public DbSet<TipoDocumento> TiposDocumento { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<Administrador> Administradores { get; set; }

        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<Proveedor> Proveedores  { get; set; }

        public DbSet<EncargadoBarra> EncargadosBarra { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PersonaConfig());
            modelBuilder.ApplyConfiguration(new RolConfig());
            modelBuilder.ApplyConfiguration(new TipoDocumentoConfig());
            modelBuilder.ApplyConfiguration(new ClienteConfig());
            modelBuilder.ApplyConfiguration(new ProveedorConfig());
            modelBuilder.ApplyConfiguration(new EncargadoBarraConfig());
            modelBuilder.ApplyConfiguration(new AdministradorConfig());
        }

    }
}
