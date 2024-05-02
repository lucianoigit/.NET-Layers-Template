using Drugstore.Domain.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Drugstore.Infrastructure.Persitence;

public class OrderConfiguration : IEntityTypeConfiguration<Order>
{
    // a la clase EntityTypeBuilder<Order> la llamo builder
    public void Configure(EntityTypeBuilder<Order> builder) 
    {
        // Configuracion de nombre de tabla y clave primaria
        builder.ToTable("Orders");
        builder.HasKey(e => e.Id);

        // Configuracion de propiedades si es que es necesario
        builder.Property(e => e.NumberOrder).IsRequired();
        builder.Property(e=>e.Description).IsRequired();

    }
}
