namespace ProductFactoryApp.Test;

using ProductFactoryApp.Core;
using ProductFactoryApp.Core.Products;
using ProductFactoryApp.Enums;

public class ProductCreatorTests
{
    [Theory]
    [InlineData("Test Book", 29.99, Category.Book, typeof(Book))]
    [InlineData("Test Electronics", 999.99, Category.Electronics, typeof(Electronics))]
    [InlineData("Test Furniture", 99.99, Category.Furniture, typeof(Furniture))]
    public void CreateProduct_Product_ShouldReturnCorrectProductType(string name, decimal price, Category category, Type expectedType)
    {
        var creator = new ProductCreator();

        var product = creator.CreateProduct(name, price, category);

        Assert.IsType(expectedType, product);
        Assert.Equal(name, product.GetName());
        Assert.Equal(price, product.GetPrice());
        Assert.Equal(category, product.GetCategory());
    }

    // TODO: Negative Scenarios
}
