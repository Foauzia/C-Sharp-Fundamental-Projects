using System;
using static System.Console;

public class Animal
{
    public string Name { get; set; }
    public DateTime Born { get; set; }
}

public class Cat : Animal
{
    public int Legs { get; set; } = 4;
    public bool IsDomestic { get; set; } = true;
}

public class Spider : Animal
{
    public bool IsPoisonous { get; set; } = false;
}

class Program
{
    static void Main(string[] args)
    {
        var animals = new Animal?[]
        {
            new Cat { Name = "Karen", Born = new(year: 2022, month: 8, day: 23), Legs = 4, IsDomestic = true },
            null,
            new Cat { Name = "Mufasa", Born = new(year: 1994, month: 6, day: 12), IsDomestic = false },
            new Spider { Name = "Sid Vicious", Born = DateTime.Today, IsPoisonous = true },
            new Spider { Name = "Captain Furry", Born = DateTime.Today }
        };

        foreach (Animal? animal in animals)
        {
            string message = animal switch
            {
                Cat { Legs: 4 } cat => $"The cat named {cat.Name} has four legs.",
                Cat { IsDomestic: false } cat => $"The non-domestic cat is named {cat.Name}.",
                Cat cat => $"The cat is named {cat.Name}.",
                Spider { IsPoisonous: true } spider => $"The {spider.Name} spider is poisonous. Run!",
                null => "The animal is null.",
                _ => $"{animal.Name} is a {animal.GetType().Name}."
            };

            WriteLine($"switch statement: {message}");
        }
    }
}
