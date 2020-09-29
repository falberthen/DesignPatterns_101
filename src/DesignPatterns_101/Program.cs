global using System;
global using System.IO;
global using System.Linq;
global using Newtonsoft.Json;
global using System.Reflection;
global using System.Collections.Generic;

namespace DesignPatterns;

class Program
{
    public static void Main()
    {
        LoadPatternOptions();
    }

    /// <summary>
    /// Options menu
    /// </summary>
    public static void LoadPatternOptions()
    {
        Console.WriteLine("\tChoose an option:");
        Console.WriteLine("\t---------------------------\n");

        var patternList = LoadJson();
        var patternGroups = patternList
            .GroupBy(x => x.Category);

        var groupedPatterns = new Dictionary<int, DesignPattern>();
        var index = 0;

        foreach (var group in patternGroups)
        {
            string groupKey = group.Key;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\t" + groupKey + " Patterns\n");

            foreach (var key in group)
            {
                ++index;
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("\t" + index + ") " + key.Name);
                groupedPatterns.Add(index, key);
            }

            Console.WriteLine("\n");
        }

        int choice = int.Parse(Console.ReadLine().ToString());
        if (groupedPatterns.ContainsKey(choice))
        {
            var pattern = groupedPatterns[choice];
            InstantiateAndInvoke(pattern);
            Console.ReadKey();
            Console.Clear();
            Main();
        }
    }

    /// <summary>
    /// Loads a list of patterns from json file
    /// </summary>
    /// <returns></returns>
    private static List<DesignPattern> LoadJson()
    {            
        using (StreamReader r = new StreamReader("designPattterns.json"))
        {
            string json = r.ReadToEnd();
            var patterns = JsonConvert
                .DeserializeObject<List<DesignPattern>>(json);

            return patterns; 
        }
    }

    /// <summary>
    /// Instance the chosen pattern and invoke Execute
    /// </summary>
    /// <param name="pattern"></param>
    /// <returns></returns>
    private static object InstantiateAndInvoke(DesignPattern pattern)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var type = assembly.GetTypes()
            .First(t => t.Name == $"{pattern.ClassName}Runner");

        var instance =  Activator.CreateInstance(type);

        Console.Clear();
        Console.WriteLine($"{pattern.Name}: {pattern.Description}\t");
        Console.ForegroundColor = ConsoleColor.White;

        MethodInfo method = type.GetMethod("Execute");
        return method.Invoke(instance, null);
    }
}
