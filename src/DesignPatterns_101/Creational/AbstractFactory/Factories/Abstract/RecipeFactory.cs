using DesignPatterns.Creational.AbstractFactory.Products.Abstract;

namespace DesignPatterns.Creational.AbstractFactory.Factories.Abstract;

/// <summary>
/// The AbstractFactory class, which defines methods for creating abstract objects.
/// </summary>
public abstract class RecipeFactory
{
    public abstract Sandwich CreateSandwich();
    public abstract Dessert CreateDessert();
}
