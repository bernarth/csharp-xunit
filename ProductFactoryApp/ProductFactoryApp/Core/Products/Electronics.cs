namespace ProductFactoryApp.Core.Products;

using ProductFactoryApp.Abstracts;
using ProductFactoryApp.Enums;

public class Electronics : ProductBase
{
    public Electronics(string name, decimal price) : base(name, price, Category.Electronics) { }
}

