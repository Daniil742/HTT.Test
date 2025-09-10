using HTT.Test.Infrastructure;

namespace HTT.Test.WebApp.BuildersExtensions;

public static class ServiceBuilder
{
    public static IServiceCollection AddServiceRegister(this IServiceCollection serviceCollection, IConfiguration configuration)
    {
        DependencyInjection.ConfigureServices(serviceCollection, configuration);

        return serviceCollection;
    }
}
