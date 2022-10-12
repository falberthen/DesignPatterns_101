using DesignPatterns.Structural.Composite.Composite;

namespace DesignPatterns.Structural.Composite;

public class CompositeRunner
{
    public static void Execute()
    {
        // Continent
        var continent = new Continent("North America");

        // Countries
        var canada = new Country("Canada");
        var usa = new Country("United States");

        // Provinces/States
        var britishColumbia = new State("British Columbia");
        var quebec = new State("Quebec");
        var ontario = new State("Ontario");
        var florida = new State("Florida");

        canada.AddBoundary(quebec);
        canada.AddBoundary(ontario);
        usa.AddBoundary(florida);

        // Cities
        britishColumbia.AddBoundary(new City("Victoria"));
        britishColumbia.AddBoundary(new City("Vancouver"));
        quebec.AddBoundary(new City("Montreal"));
        quebec.AddBoundary(new City("Quebec City"));
        ontario.AddBoundary(new City("Toronto"));
        ontario.AddBoundary(new City("Ottawa"));
        florida.AddBoundary(new City("Orlando"));
        florida.AddBoundary(new City("Miami"));

        continent.AddBoundary(canada);
        continent.AddBoundary(usa);

        continent.DisplayChilds(2);
    }
}
