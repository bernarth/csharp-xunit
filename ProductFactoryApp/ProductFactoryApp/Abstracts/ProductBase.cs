namespace ProductFactoryApp.Abstracts;

using ProductFactoryApp.Enums;
using ProductFactoryApp.Interfaces;

public abstract class ProductBase : IProduct
{
    public string Name { get; private set; }
    
    public decimal Price { get; private set; }
    
    public Category Category { get; private set; }

    protected ProductBase(string name, decimal price, Category category)
    {
        Name = name;
        Price = price;
        Category = category;
    }

    public string GetName() => Name;
    
    public decimal GetPrice() => Price;
    
    public Category GetCategory() => Category;
}

