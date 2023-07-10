namespace api.Services;

public class Services
{
    public static void Configure(IServiceCollection services)
    {
        services.AddScoped<IPlanetService, PlanetService>();
    }
}
