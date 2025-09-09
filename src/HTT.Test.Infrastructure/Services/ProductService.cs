using HTT.Test.Contracts.DTOs;
using HTT.Test.Contracts.Interfaces;
using HTT.Test.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace HTT.Test.Infrastructure.Services;

internal class ProductService(
    IDbContextFactory<TestDbContext> dbContextFactory
    ) : IProductService
{
    private readonly IDbContextFactory<TestDbContext> _dbContextFactory = dbContextFactory;

    public async Task<IReadOnlyCollection<ProductDto>> GetProductsInfo()
    {
        await using var context = await _dbContextFactory.CreateDbContextAsync();

        var query = from p in context.Products

                    join c in context.ProductCategories on p.CategoryId equals c.Id into categoryGroup

                    from g in categoryGroup.DefaultIfEmpty()

                    select new ProductDto
                    {
                        Id = p.Id,
                        Name = p.Name,
                        CategoryName = g != null ? g.Name : "Без категории"
                    };

        return await query.ToArrayAsync();
    }
}
