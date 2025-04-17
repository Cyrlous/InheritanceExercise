using System;

namespace Inheritance;

public class Animal
{
    //Properties
    public string Name { get; set; }
    public string Sound { get; set; }
    public string Species { get; set; }

    //Methods
    public void MakeNoise()
    {
        Console.WriteLine($"{Name} says {Sound}.");
    }
}