using System;

namespace CSharpStudy.Code.Core
{
    public class Objects
    {
        static void Object(string[] args)
        {
            // Creating an array and setting a size
            Fruits[] fruits = new Fruits[3];

            // Creating objects from our class
            Fruits fruit1 = new Fruits("Apple", "red");
            Fruits fruit2 = new Fruits("Orange", "orange");
            Fruits fruit3 = new Fruits("Grapes", "purple");

            // Assigning them to the array index
            fruits[0] = fruit1;
            fruits[1] = fruit2;
            fruits[2] = fruit3;

            // Creating an array of objects
            Fruits[] Fruits =
            {
                new Fruits("Apple", "red"),
                new Fruits("Orange", "orange"),
                new Fruits("Grapes", "purple")
            };

            // Printing an individual array element from an array of objects
            Console.WriteLine(Fruits[0].fruit);

            // Iterating through the array and printing each array element
            foreach (Fruits fruit in Fruits)
            {
                Console.WriteLine(fruit.fruit);
            }

            // Invoking a method that changes a specified property
            ChangeColor(fruit1, "green");
            Console.WriteLine(fruit1.color);

            // Using a method to change a property from an array of objects
            ChangeColor(Fruits[2], "green");
            Console.WriteLine(Fruits[2].color);

            // Invoking a method that returns an object as a parameter.
            Fruits fruit4 = Copy(fruit3);
            Console.WriteLine(fruit4.color + " " + fruit4.fruit);
        }

        // Passing in a class and property that we want to affect
        public static void ChangeColor(Fruits fruit, String color)
        {
            fruit.color = color;
        }

        // Takes an existing class and returning a new object as a method
        public static Fruits Copy(Fruits fruit)
        {
            return new Fruits(fruit.fruit, fruit.color);
        }
    }

    public class Fruits
    {
        public string fruit;
        public string color;

        public Fruits(String fruit, String color)
        {
            this.fruit = fruit;
            this.color = color;
        }
    }
}

