using System;
using System.Collections.Generic;

namespace CSharpStudy.Code.Core
{
    public class Lists
    {
        /* List - data structure that represents a list of objects that can be accessed by index.
         *      - SImilar to array but can dynamically increase/decrease in size
         *      - using System.Collections.Generic;
         */
        static void List(string[] args)
        {
            // Declaring a list
            List<string> foods = new List<string>();

            // Unlike arrays, lists don't require a specified fixed size when being declared
            List<int> numbersList = new List<int>();

            // Adding elements to a list
            foods.Add("ramen");
            foods.Add("pizza");
            foods.Add("sushi");
            foods.Add("ramen");

            // Printing a specific element inside a list
            Console.WriteLine(foods[1]);

            // Counting the number of elements inside a list
            Console.WriteLine(foods.Count);

            // Removes an elements from a list
            foods.Remove("pizza");

            // Inserts an element at a given index
            foods.Insert(1, "oden");

            // Gets the index of a given element
            Console.WriteLine(foods.IndexOf("oden"));

            // Gets the last index of a given list
            Console.WriteLine(foods.LastIndexOf("ramen"));

            // Returns a good value if a list contains a given string element
            Console.WriteLine(foods.Contains("burger"));

            // Auto sorts a list either alphabetically or numerically
            foods.Sort();

            // Sorts a list in reverse order
            foods.Reverse();

            // Iterating on a list using a foreach loop
            foreach (String food in foods)
            {
                Console.WriteLine(food);
            }

            // Converts a list into an array
            String[] foodsArray = foods.ToArray();

            // Clears a list
            foods.Clear();
        }
    }   
}

