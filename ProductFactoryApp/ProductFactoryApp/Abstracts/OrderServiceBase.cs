namespace ProductFactoryApp.Abstracts;

using System.Linq;
using ProductFactoryApp.Interfaces;
using System.Collections.Generic;
using ProductFactoryApp.Enums;

public abstract class OrderServiceBase : IOrderService
{
    protected readonly List<IProduct> _products;

    protected OrderServiceBase()
    {
        _products = [];
    }

    public abstract void AddProduct(IProduct product);
    
    public abstract void RemoveProduct(IProduct product);

    public decimal GetTotalPrice() => _products.Sum(p => p.GetPrice());

    public List<IProduct> GetProducts() => [.. _products];

    public List<IProduct> GetProductsByCategory(Category category) => _products.Where(p => p.GetCategory() == category).ToList();

    public IProduct GetMostExpensiveProduct() => _products.OrderByDescending(p => p.GetPrice()).FirstOrDefault();

    public IProduct SearchProductByName(string name) => _products.FirstOrDefault(p => p.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
}

