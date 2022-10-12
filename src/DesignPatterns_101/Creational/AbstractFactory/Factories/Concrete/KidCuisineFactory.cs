using DesignPatterns.Creational.AbstractFactory.Factories.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Abstract;
using DesignPatterns.Creational.AbstractFactory.Products.Concrete;

namespace DesignPatterns.Creational.AbstractFactory.Factories.Concrete;

public class KidCuisineFactory : RecipeFactory
{
    public override Dessert CreateDessert()
    {
        return new IceCreamSundae();
    }

    public override Sandwich CreateSandwich()
    {
        return new GrilledCheese();
    }
}
