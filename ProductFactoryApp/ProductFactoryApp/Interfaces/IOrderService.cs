namespace ProductFactoryApp.Interfaces;

using System.Collections.Generic;
using ProductFactoryApp.Enums;

public interface IOrderService
{
    void AddProduct(IProduct product);
    
    decimal GetTotalPrice();
    
    List<IProduct> GetProducts();
    
    void RemoveProduct(IProduct product);
    
    List<IProduct> GetProductsByCategory(Category category);
    
    IProduct GetMostExpensiveProduct();
    
    IProduct SearchProductByName(string name);
}

