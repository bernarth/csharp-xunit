namespace ProductFactoryApp.Core;

using ProductFactoryApp.Abstracts;
using ProductFactoryApp.Core.Products;
using ProductFactoryApp.Enums;
using ProductFactoryApp.Interfaces;

public class ProductCreator : CreatorBase
{
    public override IProduct CreateProduct(string name, decimal price, Category category)
    {
        return category switch
        {
            Category.Book => new Book(name, price),
            Category.Electronics => new Electronics(name, price),
            Category.Furniture => new Furniture(name, price),
            _ => throw new ArgumentException("Unknown product category."),
        };
    }
}

