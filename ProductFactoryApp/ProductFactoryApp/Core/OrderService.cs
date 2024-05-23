namespace ProductFactoryApp.Core;

using ProductFactoryApp.Abstracts;
using ProductFactoryApp.Interfaces;

public class OrderService : OrderServiceBase
{
    public override void AddProduct(IProduct product)
    {
        _products.Add(product);
    }

    public override void RemoveProduct(IProduct product)
    {
        _products.Remove(product);
    }
}

