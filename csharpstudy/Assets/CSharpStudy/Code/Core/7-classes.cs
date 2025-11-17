using System;

namespace CSharpStudy.Code.Core
{
  class Classes
{
    static void Class(string[] args)
    {
        string player1 = "John";
        string rival = "Mary";

        // Creating a player, but we haven't initialized or created an object yet.
        Player playerNotInitialized;

        // Creating a new player object and initializing it.
        Player player = new Player(player1);

        // Creating a separate object that inherits from the same player class.
        Player player2 = new Player(rival);

        // Accessing some method or function from within a class
        player.SayHello();

        // Accessing the same method through a different object.
        player2.SayHello();

        // Accessing a class field/attribute/variable.Objects created are separate & unique, each with their own
        // data.
        player.name = "Player 1";
        player2.name = "Player 2";

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

    /* Example 1: Classes - A bundle of related code
                          - A blueprint for creating objects
    */
    class Player
    {
        // Defining class attributes/field/class variables. Class variables can be access from other methods within the
        // class code block. When creating a class field, a values does not need to be assigned.
        // Classes do not need parenthesis and cannot be created within functions/methods. They have to be created
        // outside it.
        
        public string name;

        /* Creating a constructor. A constructor can be thought off as a method/function inside a class that
         * defines the different parameters or attributes used by the class. For a method to be considered a
         * constructor, it has to use the same naming convention & casing as the class.
         *
         * Constructors are private by default and in order for other classes or functions to access them, they
         * must be made public.
         *
         *  Parameters within constructors have no knowledge or connection to class fields. Two ways of solving this:
         *      - Rename the constructor's parameters to something else.
         *      - Use the this. keyword to reference this object's field/clas variable.
         */
        public Player(string _name)
        {
            Console.WriteLine("Creating player constructor...");
            name = _name;
            // Passing in a parameter in the constructor
            Console.WriteLine($"Welcome {name}");
        }

        public void SayHello()
        {
            Console.WriteLine("Hello...");
            // Accessing a class variable/field/attribute
            Console.WriteLine($"Hello, {name}!");
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

