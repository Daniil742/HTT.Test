using HTT.Test.Contracts.Interfaces;
using HTT.Test.Infrastructure.Services;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace HTT.Test.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection ConfigureServices(IServiceCollection serviceCollection, IConfiguration configuration)
    {
        serviceCollection.AddScoped<IProductService, ProductService>();

        return serviceCollection;
    }
}
