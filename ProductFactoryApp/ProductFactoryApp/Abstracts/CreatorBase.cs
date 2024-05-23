namespace ProductFactoryApp.Abstracts;

using ProductFactoryApp.Enums;
using ProductFactoryApp.Interfaces;

public abstract class CreatorBase
{
    public abstract IProduct CreateProduct(string name, decimal price, Category category);
}

