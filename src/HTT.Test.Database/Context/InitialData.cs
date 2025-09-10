using HTT.Test.Database.DataModels;

namespace HTT.Test.Database.Context;

public class InitialData
{
    private static readonly List<ProductCategoryDataModel> _categories = new List<ProductCategoryDataModel>
    {
        new() { Id = 1, Name = "Электроника" },
        new() { Id = 2, Name = "Одежда" },
        new() { Id = 3, Name = "Книги" },
        new() { Id = 4, Name = "Спорт" },
        new() { Id = 5, Name = "Мебель" }
    };

    public static List<ProductDataModel> InitProducts()
    {
        var electronicsId = _categories.First(c => c.Name == "Электроника").Id;
        var clothesId = _categories.First(c => c.Name == "Одежда").Id;
        var booksId = _categories.First(c => c.Name == "Книги").Id;

        return new List<ProductDataModel>
        {
            new() { Id = 1, Name = "Смартфон", CategoryId = electronicsId },
            new() { Id = 2, Name = "Ноутбук", CategoryId = electronicsId },
            new() { Id = 3, Name = "Футболка", CategoryId = clothesId },
            new() { Id = 4, Name = "Джинсы", CategoryId = clothesId },
            new() { Id = 5, Name = "Программирование на C#", CategoryId = booksId },
            new() { Id = 6, Name = "Война и мир", CategoryId = booksId },
            new() { Id = 7, Name = "Наушники", CategoryId = electronicsId }
        };
    }

    public static List<ProductCategoryDataModel> InitProductCategories() => _categories;
}
