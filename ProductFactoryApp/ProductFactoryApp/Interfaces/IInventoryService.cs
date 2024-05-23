namespace ProductFactoryApp.Interfaces;

using System.Collections.Generic;

public interface IInventoryService
{
    void AddProduct(IProduct product, int quantity);
    
    bool RemoveProduct(IProduct product, int quantity);
    
    int GetProductQuantity(IProduct product);
    
    Dictionary<IProduct, int> GetInventory();
    
    List<IProduct> GetLowStockProducts(int threshold);
    
    IProduct SearchProductByName(string name);
}

