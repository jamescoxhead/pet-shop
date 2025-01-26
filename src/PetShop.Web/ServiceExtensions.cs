namespace PetShop.Web;

public static class ServiceExtensions
{
    public static IServiceCollection AddWebServices(this IServiceCollection services)
    {
        services.AddRazorPages();

        return services;
    }
}
