namespace api.Repositories;

public class Repositories
{
    public static void Configure(IServiceCollection services)
    {
        services.AddScoped<IPlanetRepository, PlanetRepository>();
    }
}
