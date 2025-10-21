using System;

namespace c_sharp_study
{
    /* Example 1: Classes - A bundle of related code
                          - A blueprint for creating objects
    */
    class Classes
    {
        static void classes (string[] args)
        {
            // Invoking a class instance from another file
            messages.Hello();
            messages.Loading();
            messages.Goodbye();
            
            /* Example 2: Objects: - An instance of a class
             *                     - A class is used for the blueprints to create objects
             *                     - Objects can have fields and methods (characteristics & actions)
             */
            Human human1 = new Human("John", 18);
            Human human2 = new Human("Ken", 24);
            
            // Manually assigning fields to a class object or overwriting an existing object's fields
            human1.name = "Sara";
            human1.age = 27;
            
            human2.name = "Ken";
            human2.age = 18;
            
            Console.WriteLine(human1.age);
            Console.WriteLine(human2.age);
            
            // Invoking a class method
            human1.Eat();
            human2.Sleep();
            
            human2.Eat();
            human2.Sleep();

            // Creating a character object & calling a function
            Character character1 = new Character("Ken", 20, 2, 4.5, false);
            double speed = character1.Jump(character1.jump, character1.speed); 
            
            // Applying an object's field to do something with an object
            if (character1.speed > 1 && character1.jump)
            {
                Console.WriteLine($"{character1.name} is jumping. His speed is {speed}.");
            }
            else
            {
                Console.WriteLine($"{character1.name} is not jumping. His speed is {speed}.");
            }
        }
        class Human
        {
            public String name;
            public int age;
            
            /* Example 3: Constructor: - A special method within a class
             *                         - Same as the class name
             *                         - If one is not created, a hidden one behind the scene is automatically created by C#
             *                         - Can be used to assign arguments to fields when creating an object
             */
            public Human(String name, int age) // Declaring a constructor. In Python this would be def __init__ method.
            {
               // Declaring fields within a constructor
               this.name = name;
               this.age = age;
            }

            public void Eat()
            {
                Console.WriteLine(name + " is eating.");
            }

            public void Sleep()
            {
                Console.WriteLine(name + " is sleeping.");
            }
        }

        class Character
        {
            // Declaring class variables
            public String name;
            public int age;
            public double speed;
            public double weight;
            public bool jump;
            
            // Creating a constructor for the character class
            public Character(String name, int age, double speed, double weight, bool jump)
            {
                this.name = name;
                this.age = age;
                this.speed = speed;
                this.weight = weight;
                this.jump = jump;
            }
            
            // Creating a jump method
            public double Jump(bool jump, double speed)
            {
                if (jump)
                {
                    speed = speed / 2;
                    return speed;
                }
                else
                {
                   speed = speed * 2;
                   return speed;
                }
            }
        }
    }
}



