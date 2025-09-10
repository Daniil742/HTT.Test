using HTT.Test.Database.DataModels;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HTT.Test.Database.Context;

public class TestDbContext : DbContext
{
    public TestDbContext(DbContextOptions options)
        : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ProductDataModel>(entity =>
        {
            entity.HasKey(p => p.Id);
            entity.Property(p => p.Name).IsRequired().HasMaxLength(100);
            entity.HasOne(p => p.Category)
                  .WithMany(c => c.Products)
                  .HasForeignKey(p => p.CategoryId);
        });

        modelBuilder.Entity<ProductCategoryDataModel>(entity =>
        {
            entity.HasKey(c => c.Id);
            entity.Property(c => c.Name).IsRequired().HasMaxLength(50);
        });

        modelBuilder.Entity<ProductDataModel>()
            .HasData(InitialData.InitProducts());

        modelBuilder.Entity<ProductCategoryDataModel>()
            .HasData(InitialData.InitProductCategories());

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<ProductDataModel> Products { get; set; }

    public DbSet<ProductCategoryDataModel> ProductCategories { get; set; }
}
