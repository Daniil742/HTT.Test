using HTT.Test.Contracts.Interfaces;

namespace HTT.Test.WebApp.Endpoints;

public static partial class Enpoints
{
    public static IEndpointRouteBuilder RegisterProductsEndpoints(this IEndpointRouteBuilder endpoints)
    {
        var mapGroup = endpoints.MapGroup("/api");

        mapGroup.MapGet("/products", async (IProductService service) =>
            Results.Ok(await service.GetProductsInfo()));

        return endpoints;
    }
}
