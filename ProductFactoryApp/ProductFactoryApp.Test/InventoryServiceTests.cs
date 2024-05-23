namespace ProductFactoryApp.Test;

using ProductFactoryApp.Core;
using ProductFactoryApp.Enums;
using ProductFactoryApp.Test.Mocks;

public class InventoryServiceTests
{
    [Fact]
    public void AddProduct_OneProductType_ShouldIncreaseProductQuantity()
    {
        var book = ProductsMock.GetProduct(Category.Book);
        var firstBookQuantity = 10;
        var secondBookQuantity = 5;
        var inventoryService = new InventoryService();
        var totalQuantity = firstBookQuantity + secondBookQuantity;

        inventoryService.AddProduct(book, firstBookQuantity);
        inventoryService.AddProduct(book, secondBookQuantity);

        Assert.Equal(totalQuantity, inventoryService.GetProductQuantity(book));
    }

    [Fact]
    public void GetLowStockProducts_TwoProductTyes_ShouldReturnProductBelowThreshold()
    {
        var book = ProductsMock.GetProduct(Category.Book);
        var electronics = ProductsMock.GetProduct(Category.Electronics);
        var bookQuantity = 2;
        var electronicsQuantity = 10;
        var threshold = 5;
        var inventoryService = new InventoryService();
        inventoryService.AddProduct(book, bookQuantity);
        inventoryService.AddProduct(electronics, electronicsQuantity);

        var lowStockProducts = inventoryService.GetLowStockProducts(threshold);

        Assert.Single(lowStockProducts);
        Assert.Equal(book, lowStockProducts.First());
    }
}
