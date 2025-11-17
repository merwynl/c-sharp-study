using System;

namespace CSharpStudy.Code.Core
{
    public class Generics
    {
    
        /* Generics - "Not specific to a particular data type"
         *          - Add <T> to classes, methods, fields, etc.
         *          - Allows for code reusability for different data types
         *
         */
        static void Generic(string[] args)
        {
            int[] intArray = {1,2,3};
            double[] doubleArray = {1.0, 2.0, 3.0};
            string[] stringArray = {"1", "2", "3"};
        
            displayElements(intArray);
            displayElements(doubleArray);
            displayElements(stringArray);
        
            // This method call now takes any and all data types
            displayElements(doubleArray);
        
        }

        static void displayElements(int[] array)
        {
            foreach (int item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void displayElements(double[] array)
        {
            foreach (double item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
        static void displayElements(string[] array)
        {
            foreach (String item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }

        // Simplifies the above 3 methods by declaring a generic
        static void displayAllElements<T>(T[] array)
        {
            foreach (T item in array)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
        }
    }
}

