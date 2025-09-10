using HTT.Test.WebApp.Endpoints;

namespace HTT.Test.WebApp.BuildersExtensions;

public static class EndpointBuilder
{
    public static void UseEndpoints(this IEndpointRouteBuilder endpoints)
    {
        endpoints.RegisterProductsEndpoints();
    }
}
