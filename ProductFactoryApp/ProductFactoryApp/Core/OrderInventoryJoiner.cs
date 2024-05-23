namespace ProductFactoryApp.Core;

using System.Collections.Generic;
using System.Linq;
using ProductFactoryApp.Interfaces;

public class OrderInventoryJoiner
{
    public static IEnumerable<(IProduct Product, int Quantity, decimal TotalPrice)> JoinOrderAndInventory(IOrderService orderService, IInventoryService inventoryService)
    {
        var orderProducts = orderService.GetProducts();
        var inventory = inventoryService.GetInventory();

        var joinResult = from product in orderProducts
                         join inv in inventory on product equals inv.Key
                         select (Product: product, Quantity: inv.Value, TotalPrice: product.GetPrice() * inv.Value);

        return joinResult;
    }
}

