﻿using DesignPatterns.Structural.Composite.Component;

namespace DesignPatterns.Structural.Composite.Composite;

/// <summary>
/// Leaf class
/// </summary>
public class City : IBoundary
{
    public City(string name)
    {
        Name = name;
    }

    public string Name { get; set; }

    public void DisplayChilds(int sub)
    {
        Console.WriteLine(new string('-', sub) + Name);
    }
}
