namespace c_sharp_study;

public class exceptions
{
    // Example 1: Exceptions - Errors that occur during execution
    //            - Try: Try some code that is considered unsafe
    //            - Except: catches and handles exceptions when they occur 
    //            - Finally: always executes regardless oif exception is caught or not
    static void Exceptions()
    {
        int x;
        int y;
        double result;

        try
        {
            Console.Write("Please enter the first number: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter the second number: ");
            y = Convert.ToInt32(Console.ReadLine());

            result = x / y;
            Console.Write("result: " + result);
        }
        catch (FormatException e)
        {
            Console.WriteLine("Enter numerical values only!");
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Zero division unaccepted!");
        }
        finally
        {
            Console.WriteLine("Press any key to exit...");
        }
    }
    
    // Example 2: Conditional Operators - Checks if a condition is true/false
    // (condition) ? x * y
    static void Conditionals()
    {
        double temperature = 27;
        String message;

        if (temperature > 18)
        {
            message = "It's warm outside!";
        }
        else
        {
            message = "It's cold outside!";
        }
        Console.WriteLine(message);
        
       // Shorthand of writing the above if statement
       message =  (temperature >= 18) ? "Its warm outside!" : "It's cold outside!";
    }

    // Example 3: String Interpolation - Allows us to insert variables into a string literal
    //                                 - Precede a string literal with $
    //                                 - {} are placeholders
    static void StringInterpolation()
    {
        String firstName = "Code";
        String lastName = "Box";
        int year = 2025;
        
        // String literal
        Console.WriteLine("Hello" + firstName + " " + lastName + "It is the year " + year);
        
        // String interpolation
        Console.WriteLine($"Hello{firstName} {lastName}. It is the year {year}");
        
        // String Formatting
        Console.WriteLine($"Hello{0} {1}. It is the year {2}", firstName, lastName, year);
    }
}