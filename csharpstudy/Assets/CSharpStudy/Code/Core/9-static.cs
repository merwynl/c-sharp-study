using System;

namespace CSharpStudy.Code.Core
{
   class StaticModifiers
    {
        /* Example 1: Static: - A modifier to declare a static member which belongs to the class itself
         *                      rather than to any specific object.
         *                    - Useful for when you require some sort of shared attribute/behaviour amongst various
         *                      objects.
         *                    - You're kinda making a member "globally accessible".
         *                    - When defining something as static, you are making that item belong to the class itself
         *                      as opposed to a specific instance or object.
         */
        static void StaticModifier(string[] args)
        {
            string player1 = "John";
            string player2 = "Jane";
            
            // The first instance is going to access the global static field value "-".
            // The following will pass the variables declared above as parameters to the constructor via Player._name
            Pawn.SayHello();
            new Pawn(player1);
            Pawn.SayHello();
            new Pawn(player2);
            Pawn.SayHello();
            
            // Accessing a static method
            Pawn.SayHello();
            
            Cars car1 = new Cars("Toyota");
            Cars car2 = new Cars("Lexus");
            Cars car3 = new Cars("Hyundai");
        
            // Accessing a public non-static field.
            Console.WriteLine(car1.model);
        
            // car1.numberofCars; can no longer be accessed from the object itself because numberofCars is static.  
            Console.WriteLine(Cars.numberofCars);
        
            // Invoking a public method
            Cars.StartRace();
        }
    }

    class Pawn
    {
        private static string _name = "-";
        public Pawn(string name)
        {
            // Accessing a this. field will not work on static members since they now belong to the class and not just
            // the specific instance.
            // this.name = _name;
            
            // Correctly accessing a static field within the constructor.
            Pawn._name = name;
            
            Console.WriteLine("Creating player constructor...");
            Console.WriteLine($"Welcome {name}!");
        }

        public static void SayHello()
        {
            Console.WriteLine($"Hello{_name}...");
            Console.WriteLine("Welcome to my game!");
        }
        
    }

    class Cars
    {
        public String model;

        public static int numberofCars;

        // Creating a constructor
        public Cars(String model)
        {
            this.model = model;
            numberofCars++; // Each time an object is instantiated, we increment by 1.
        }

        // Creating a public static method. All objects will have access to this method
        public static void StartRace()
        {
            Console.WriteLine("The race has now begun!");
        }
    } 
}

