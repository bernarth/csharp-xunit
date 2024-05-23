namespace ProductFactoryApp.Test;

using ProductFactoryApp.Core.Products;
using ProductFactoryApp.Enums;

public class ProductTests
{
    [Fact]
    public void Book_Initialized_ShouldBeInitializedCorrectly()
    {
        var name = "Test Book";
        var price = 29.99m;

        var book = new Book(name, price);

        Assert.NotNull(book);
        Assert.Equal(name, book.Name);
        Assert.Equal(price, book.Price);
        Assert.Equal(Category.Book, book.Category);
    }

    [Fact]
    public void Electronics_Initialized_ShouldBeInitializedCorrectly()
    {
        // TODO: Complete test
        Assert.True(true);
    }

    [Fact]
    public void Furniture_Initialized_ShouldBeInitializedCorrectly()
    {
        // TODO: Complete test
        Assert.True(true);
    }
}
