using api.Settings;

namespace api;

public class Env
{
    public static void Configure(IServiceCollection services, ConfigurationManager config)
    {
        services.Configure<DbSettings>(config.GetSection("DbSettings"));
    }
}
