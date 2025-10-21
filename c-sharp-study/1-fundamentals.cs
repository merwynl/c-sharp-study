using System;

namespace c_sharp_study;

class fundamentals
{
    // C# needs a main function for a project to run. Only one main function can exist in any given project  
    static void Base(string[] args)
    {
        // Printing a string literal to the console with a linebreak
        Console.Write("Hello! ");

        // Printing a string literal no linebreak
        Console.WriteLine("Welcome to Codebox!");

        // Regular comment

        /*
         * Multi-line comment
         */

        // Tab escape sequence
        Console.WriteLine("\tWelcome to Codebox!");

        // Backspace escape sequence
        Console.WriteLine("Welcome to Codebox\b!");

        // Newline escape sequence
        Console.WriteLine("Welcome to \nCodebox!");

        // Variables in C# takes two steps. 1. Declaration 2. Initialization
        // Declaring variables. Case sensitive.
        int x;
        bool guessed;
        x = 123;
        int y = 321; // Declaring & initializing vars in the same line.

        int z = x + y;
        int age = 25;

        // C# Data types
        int a = 1; // whole integer numbers
        float b = 2.5f; // floating numbers
        double c = 5.3; // Larger than a float. Typically, 8 bytes. 
        decimal d = 3; //decimalNumber
        bool boole = true; // boolean. True or False
        string str = "String"; // string characters in double quotes
        short shortNumber = 1; // For ints smaller than 4 bytes
        long longNumber = 2345; // Ints larger than 4 bytes
        char character = '@'; // Single characters in single quotes


        // Printing variables
        Console.WriteLine(str);

        // Concatenating strings and numerical variables
        Console.WriteLine("Your age is " + age);

        // Concatenating strings and characters
        Console.WriteLine(str + character);

        /*
         * Constants = Immutable values known at compile time
         *           = Do not change for the life of the program
         */

        // Declaring a constant. This value can't be changed.
        const double pi = 3.14;

        // Type casting a double float to an int
        double num = 3.14;
        int type_casted = Convert.ToInt32(num);
        Console.WriteLine(type_casted);

        // Type casting a character to a string
        char response = 'y';
        string str_casted = Convert.ToString(response);
        Console.WriteLine(str_casted);

        // Type casting a string to a boole
        string answer = "true";
        bool reply = Convert.ToBoolean(answer);

        // Type casting an int to a double
        int e = 4;
        double f = Convert.ToDouble(e);

        // Getting the data type of incoming variable.
        Console.WriteLine(reply.GetType());

        // Inserts a single quote inside a string
        string message = "It\'s all right!";

        // String formatting to include quotations inside of strings
        string myString = "\"Code Monkey\"";

        // Inserts a single backslash
        string backslash = "This \\  is single backslash";

        // Inserts a double backslash
        string doubleBackslash = "This \\\\ a double backslash!";

        // Keeps program running until key is entered.
        Console.ReadKey();

    }
}