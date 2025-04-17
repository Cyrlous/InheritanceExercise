using System;

namespace Inheritance;

public class Reptile : Animal
{
    //Properties
    public bool HasLegs { get; set; }
    public bool CanSwim { get; set; }

    //Methods
    public void Swim(string name)
    {
        if (CanSwim)
        {
            Console.WriteLine($"The {name} swims smoothly through the water.");
        }
        else
        {
            Console.WriteLine($"The {name} is not able to swim.");
        }
    }

    public void Move(string name)
    {
        if (HasLegs)
        {
            Console.WriteLine($"The {name} crawls across the ground on its reptilian legs.");
        }
        else
        {
            Console.WriteLine($"The {name} slithers across the ground on its belly.");
        }
    }
}