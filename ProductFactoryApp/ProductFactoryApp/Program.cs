using ProductFactoryApp.Abstracts;
using ProductFactoryApp.Core;
using ProductFactoryApp.Enums;
using ProductFactoryApp.Interfaces;

namespace ProductFactoryApp;

public class Program
{
    static void Main()
    {
        var creator = new ProductCreator();
        var orderService = new OrderService();
        var inventoryService = new InventoryService();

        var book = creator.CreateProduct("C# in Depth", 45.99m, Category.Book);
        var electronics = creator.CreateProduct("Headphones", 89.99m, Category.Electronics);
        var furniture = creator.CreateProduct("Chair", 59.99m, Category.Furniture);

        inventoryService.AddProduct(book, 10);
        inventoryService.AddProduct(electronics, 5);
        inventoryService.AddProduct(furniture, 2);

        Console.WriteLine("Inventory:");
        foreach (var item in inventoryService.GetInventory())
        {
            Console.WriteLine($"{item.Key.GetName()} - Quantity: {item.Value}");
        }

        orderService.AddProduct(book);
        orderService.AddProduct(electronics);

        Console.WriteLine("\nOrder:");
        foreach (var product in orderService.GetProducts())
        {
            Console.WriteLine($"{product.GetName()} - ${product.GetPrice()}");
        }

        Console.WriteLine($"\nTotal Price: ${orderService.GetTotalPrice()}");

        var mostExpensiveProduct = orderService.GetMostExpensiveProduct();
        Console.WriteLine($"\nMost Expensive Product: {mostExpensiveProduct.GetName()} - ${mostExpensiveProduct.GetPrice()}");

        var books = orderService.GetProductsByCategory(Category.Book);
        Console.WriteLine("\nBooks in Order:");
        foreach (var bookProduct in books)
        {
            Console.WriteLine($"{bookProduct.GetName()} - ${bookProduct.GetPrice()}");
        }

        var lowStockProducts = inventoryService.GetLowStockProducts(3);
        Console.WriteLine("\nLow Stock Products:");
        foreach (var lowStockProduct in lowStockProducts)
        {
            Console.WriteLine($"{lowStockProduct.GetName()} - Quantity: {inventoryService.GetProductQuantity(lowStockProduct)}");
        }

        var joinedData = OrderInventoryJoiner.JoinOrderAndInventory(orderService, inventoryService);
        Console.WriteLine("\nOrder and Inventory Joined:");
        foreach (var (Product, Quantity, TotalPrice) in joinedData)
        {
            Console.WriteLine($"{Product.GetName()} - Quantity: {Quantity} - Total Price: ${TotalPrice}");
        }

        var searchedProduct = orderService.SearchProductByName("Headphones");
        Console.WriteLine($"\nSearched Product in Order: {searchedProduct?.GetName()} - ${searchedProduct?.GetPrice()}");

        var searchedInventoryProduct = inventoryService.SearchProductByName("Chair");
        Console.WriteLine($"\nSearched Product in Inventory: {searchedInventoryProduct?.GetName()} - Quantity: {inventoryService.GetProductQuantity(searchedInventoryProduct)}");
    }
}
