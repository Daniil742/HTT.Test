using HTT.Test.Contracts.DTOs;
using HTT.Test.Contracts.Interfaces;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HTT.Test.WebApp.Pages;

public class ProductsModel(IProductService productService) : PageModel
{
    private readonly IProductService _productService = productService;

    public IReadOnlyCollection<ProductDto> Products { get; private set; } = new List<ProductDto>();

    public async Task OnGetAsync()
    {
        Products = await _productService.GetProductsInfo();
    }
}
