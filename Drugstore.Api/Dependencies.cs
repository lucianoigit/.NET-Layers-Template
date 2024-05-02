using Drugstore.Application.Order;
using Drugstore.Domain.Order;
using Drugstore.Infrastructure.Persitence;

namespace Drugstore.Api
{
    // Contenedor de servicios del tipo IServiceCollection 
    public static class DependencyApiRegisters
    {
        public static IServiceCollection ConfigureServices(IServiceCollection services, IConfiguration configuration)
        {
            // Configuración de servicios como Entity Framework, autenticación, etc.
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();

            return services;
        }
    }
}
