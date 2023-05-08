using Inventory.Api.Services;
using Inventory.Api.Settings;

namespace Inventory.Api;

public static class Bootstrapper
{
    public static void AddConfigurations(this IServiceCollection services, IConfiguration configuration)
    {
        services.Configure<MongoSettings>(configuration.GetSection(nameof(MongoSettings)));
    }
    
    public static void AddServices(this IServiceCollection services)
    {
        services.AddSingleton<MongoService>();
    }
}