namespace ProductFactoryApp.Core.Products;

using ProductFactoryApp.Abstracts;
using ProductFactoryApp.Enums;

public class Book : ProductBase
{
    public Book(string name, decimal price) : base(name, price, Category.Book) { }
}

