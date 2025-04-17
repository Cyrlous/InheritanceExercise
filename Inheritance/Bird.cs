using System;

namespace Inheritance;

public class Bird : Animal
{
    //Properties
    public string MaleColor { get; set; }
    public string FemaleColor { get; set; }
    public bool CanFly { get; set; }

    //Methods
    public void Fly(string name)
    {
        if (CanFly)
        {
            Console.WriteLine($"The {name} soars high into the sky!");
        }
        else
        {
            Console.WriteLine($"The {name} is unfortunately unable to fly.");
        }
    }
    
    
}