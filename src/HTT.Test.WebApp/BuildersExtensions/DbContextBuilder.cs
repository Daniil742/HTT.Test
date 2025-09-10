using HTT.Test.Database.Context;
using Microsoft.EntityFrameworkCore;

namespace HTT.Test.WebApp.BuildersExtensions;

public static class DbContextBuilder
{
    public static void AddDbContext(this IHostApplicationBuilder builder)
    {
        builder.Services.AddDbContextFactory<TestDbContext>(options =>
        {
            options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
        });
    }
}
