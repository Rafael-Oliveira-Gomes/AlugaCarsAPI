using AlugaCars.Core.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AlugaCars.DataAcess.Persistence
{
    public class DataContext : IdentityDbContext<Usuario, ApplicationRole, string>
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<ApplicationRole> Roles { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            builder.Entity<Usuario>().ToTable("AspNetUsers").HasKey(t => t.Id);

            base.OnModelCreating(builder);
        }
    }
}
