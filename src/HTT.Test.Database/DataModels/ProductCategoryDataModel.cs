namespace HTT.Test.Database.DataModels;

public sealed class ProductCategoryDataModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<ProductDataModel> Products { get; set; } = new();
}
