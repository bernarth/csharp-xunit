namespace ProductFactoryApp.Core.Products;

using ProductFactoryApp.Abstracts;
using ProductFactoryApp.Enums;

public class Furniture : ProductBase
{
    public Furniture(string name, decimal price) : base(name, price, Category.Furniture) { }
}

