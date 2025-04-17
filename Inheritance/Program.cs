using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common

            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var robin = new Bird()
            {
                Name = "Robin",
                Sound = "Chirp!",
                Species = "migratorius",
                MaleColor = "red",
                FemaleColor = "brown",
                CanFly = true
            };
            
            Console.WriteLine($"The {robin.Name} is of the species {robin.Species}.");
            Console.WriteLine($"The male of the species is primarily {robin.MaleColor} while the female is primarily {robin.FemaleColor}.");
            robin.MakeNoise();
            robin.Fly(robin.Name);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var indianPython = new Reptile()
            {
                Name = "Indian Python",
                Sound = "Ssssssssss!!",
                Species = "molurus",
                HasLegs = false,
                CanSwim = true
            };
            
            Console.WriteLine($"\nThe {indianPython.Name} is of the species {indianPython.Species}.");
            indianPython.MakeNoise();
            indianPython.Move(indianPython.Name);
            indianPython.Swim(indianPython.Name);
        }
    }
}
