
using Drugstore.Domain.Order;
using Drugstore.Infrastructure.Context;
using Drugstore.Infrastructure.Persitence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Drugstore.Infrastructure;

// Contenedor de servicios del tipo IServiceCollection 
public static class DependencyInfraestructureRegisters
{
    public static IServiceCollection ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        // Aca agrego servicios como configuracion de base de datos, auth (clerck) , etc
        services.AddDbContext<ApplicationDbContext>(options => options.UseNpgsql(configuration.GetConnectionString("pgdb")));


        return services;
        
    }
}