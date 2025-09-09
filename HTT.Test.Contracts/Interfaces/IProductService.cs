using HTT.Test.Contracts.DTOs;

namespace HTT.Test.Contracts.Interfaces;

public interface IProductService
{
    Task<IReadOnlyCollection<ProductDto>> GetProductsInfo();
}
