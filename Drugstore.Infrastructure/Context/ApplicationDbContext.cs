using Drugstore.Domain.Order;
using Drugstore.Infrastructure.Persitence;
using Microsoft.EntityFrameworkCore;

namespace Drugstore.Infrastructure.Context;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Order> Orders { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Aplicar la configuración de Order utilizando la clase OrderConfiguration
        modelBuilder.ApplyConfiguration(new OrderConfiguration());

        // Otros mapeos y configuraciones de entidad según sea necesario
    }
}
