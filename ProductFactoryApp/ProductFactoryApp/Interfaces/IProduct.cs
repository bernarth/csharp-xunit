namespace ProductFactoryApp.Interfaces;

using ProductFactoryApp.Enums;

public interface IProduct
{
    string GetName();

    decimal GetPrice();
    
    Category GetCategory();
}

