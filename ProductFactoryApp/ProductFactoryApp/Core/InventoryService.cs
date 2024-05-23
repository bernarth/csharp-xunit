namespace ProductFactoryApp.Core;

using System.Collections.Generic;
using System.Linq;
using ProductFactoryApp.Interfaces;

public class InventoryService : IInventoryService
{
    private readonly Dictionary<IProduct, int> _inventory = [];

    public void AddProduct(IProduct product, int quantity)
    {
        if (_inventory.ContainsKey(product))
        {
            _inventory[product] += quantity;
        }
        else
        {
            _inventory[product] = quantity;
        }
    }

    public bool RemoveProduct(IProduct product, int quantity)
    {
        if (_inventory.TryGetValue(product, out int value) && value >= quantity)
        {
            _inventory[product] -= quantity;
            
            if (_inventory[product] == 0)
            {
                _inventory.Remove(product);
            }
            
            return true;
        }
        
        return false;
    }

    public int GetProductQuantity(IProduct product) => _inventory.TryGetValue(product, out int value) ? value : 0;

    public Dictionary<IProduct, int> GetInventory() => new(_inventory);

    public List<IProduct> GetLowStockProducts(int threshold) => _inventory.Where(kvp => kvp.Value < threshold).Select(kvp => kvp.Key).ToList();

    public IProduct SearchProductByName(string name) => _inventory.Keys.FirstOrDefault(p => p.GetName().Equals(name, StringComparison.OrdinalIgnoreCase));
}

