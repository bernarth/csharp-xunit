namespace ProductFactoryApp.Test.Mocks;

using ProductFactoryApp.Core;
using ProductFactoryApp.Enums;
using ProductFactoryApp.Interfaces;

public static class ProductsMock
{
    public const string _productName = "Name product";
    public const decimal _productPrice = 123;

    public static IProduct GetProduct(Category category)
    {
        var creator = new ProductCreator();

        return creator.CreateProduct(_productName, _productPrice, category);
    }
}
