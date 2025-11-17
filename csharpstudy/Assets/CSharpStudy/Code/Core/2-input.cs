using System;

namespace CSharpStudy.Code.Core
{
    public class Inputs
    {
        static void UserInput(string[] args)
        {
            // Accepting some user input
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();

            // Taking an input & type casting to an int
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Hello " + name + "! " + "You are " + age + " years old.");

        }

        // Increment Operators
        static void IncrementOperations(string[] args)
        {
            int x = 1;

            // Shorthand addition or increment. x = x + 1. 2nd method often found in loops.
            x += 1;
            x++;

            // Shorthand subtraction or decrement. x = x - 1.
            x -= 1;
            x--;

            // Shorthand multiplication. x = x * 2. Decimal values are truncated.
            x *= 2;

            // Shorthand division. x = x / 2. Returns an int.
            x /= 2;

            // Shorthand modulus. x = x % 1. Returns the remainder of x / 1.
            int remainder = 5;

            float k = 50 % remainder;
        }

        // Math methods
        static void MathMethods(string[] args)
        {
            double x = -5.75;
            double y = 2.25;

            // Returns the result of an exponent
            double a = Math.Pow(x, 3);

            // Returns the square root of a given value
            double b = Math.Sqrt(x);

            // Returns the absolute value. Turns a negative number into a positive
            double c = Math.Abs(x);
            Console.ReadKey();

            // Rounds a number to the nearest whole integer
            double r = Math.Round(9.75);

            // Rounds a number up to the nearest whole integer
            double ceil = Math.Ceiling(9.75);

            // Rounds a number down to the nearest whole integer
            double f = Math.Floor(9.75);

            // Returns the highest of two incoming numbers
            double max = Math.Max(x, y);

            // Returns the lowest of two incoming numbers
            double min = Math.Min(x, y);
        }

        // Generating pseudo random numbers
        static void RandomNumbers(string[] args)
        {
            // Instantiating an object instance of the random class
            Random someRandomNumber = new Random();

            // Generates a non-negative random int.Takes a min and max range value
            int numA = someRandomNumber.Next(1, 21);

            // Generates a non-negative random between 101 & 106.
            int numB = someRandomNumber.Next(1, 7) + 100;

            // Generates a random double float number between 0-1.
            double numC = someRandomNumber.NextDouble();

            Console.WriteLine(numC);

            Console.ReadKey();
        }

        // Calculates the circumference of a circle
        static void Circumference(string[] args)
        {
            Console.WriteLine("Please enter the circumference between 1 and 100: ");
            double radius = Convert.ToInt32(Console.ReadLine());
            double c = Math.Round(2 * Math.PI * radius);

            Console.WriteLine("The circumference of the circle is " + c + "cm");
        }

        // Calculate the area od a circle
        static void CircleArea(string[] args)
        {
            Console.WriteLine("Please enter the diameter value: ");
            double diameter = Convert.ToInt32(Console.ReadLine());
            double area = Math.Round(Math.PI * ((diameter / 2) * 2), 2);
            Console.WriteLine("The area of the circle is: " + area + "cm².");
        }

        // Calculate the area of a rectangle
        static void RectangleArea(string[] args)
        {
            Console.WriteLine("Please enter a width value: ");
            double width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a length value: ");
            double length = Convert.ToInt32(Console.ReadLine());

            double area = width * length;
            Console.WriteLine("The area of the rectangle is: " + area + "cm².");
        }

        // Calculate the volume of a cube
        static void RectangleVolume(string[] args)
        {
            Console.WriteLine("Please enter a width value: ");
            double width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a length value: ");
            double length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Please enter a depth value: ");
            double depth = Convert.ToInt32(Console.ReadLine());

            double volume = width * length * depth;
            Console.WriteLine("The volume of the rectangle is: " + volume + "cm3.");
        }

        // Calculates the hypotenuse of a triangle
        static void Hypotenuse(string[] args)
        {
            Console.WriteLine("Please enter the length of Side A: ");
            double SideA = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please enter the width of Side B: ");
            double SideB = Convert.ToDouble(Console.ReadLine());

            double SideC = Math.Sqrt((SideA * SideA) + (SideB * SideB));
            Console.WriteLine("The length of Side C is: " + SideC + "cm.");

        }

        // String Methods
        static void StringMethods(string[] args)
        {
            String FullName = "Code Box";
            String Number = "123-456-789";

            // Converts entire string to upper case
            FullName = FullName.ToUpper();
            Console.WriteLine(Number);

            // Converts entire string to lower case
            FullName = FullName.ToLower();
            Console.WriteLine(Number);

            // Replaces a specified string with another set of strings
            Number = Number.Replace("-", "\\");
            Console.WriteLine(Number);

            // Removes the last character of a given string
            Number = Number.Remove(Number.Length - 1, 1);
            Console.WriteLine(Number);

            // Removes the first 3 letters of a given string with a given index
            Number = Number.Remove(0, 4);
            Console.WriteLine(Number);

            // Inserts a string at the end of another string 
            Number = Number.Insert(Number.Length, "9");
            Console.WriteLine(Number);

            // Inserts a string at the start of another string with a given index
            Number = Number.Insert(0, "123\\");
            Console.WriteLine(Number);

            // Replaces a specified string with another set of strings
            Number = Number.Replace("\\", "-");
            Console.WriteLine(Number);

            // Returns the given amount of characters in a string
            Console.WriteLine(Number.Length);

            String FirstName = FullName.Substring(0, 4);
            String LastName = FullName.Substring(5, 3);

            Console.WriteLine(FirstName);
            Console.WriteLine(LastName);
        }
    }
}

