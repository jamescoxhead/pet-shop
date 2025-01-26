using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace PetShop.Infrastructure;

public static class ServiceExtensions
{
    /// <summary>
    /// Adds infrastructure layer services to the DI container.
    /// </summary>
    /// <param name="services">The service collection.</param>
    /// <param name="configuration">Application configuration.</param>
    /// <returns>The service collection with infrastructure services.</returns>
    /// <exception cref="InvalidOperationException"></exception>
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration) => services;
}
