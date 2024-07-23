using AlugaCars.Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace AlugaCars.DataAcess.Persistence
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> opts) : base(opts) { }

        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Carro> Carros { get; set; }
        public DbSet<Reserva> Reservas { get; set; }
        public DbSet<Pagamento> Pagamentos { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            base.OnModelCreating(builder);
        }
    }
}
