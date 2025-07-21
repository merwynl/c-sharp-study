namespace c_sharp_study;

public class methods
{
    
    // Methods - or functions. Performs a section of code whenever it is invoked.
    //           - Allows for code reuse.
    static void Methods(string[] args)
    {
        // Example 1: Invoking a method
        SayHello();
        
        // Example 2: Passing in an argument to a function/method
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        Console.Write("Please enter your age: ");
        int age = Convert.ToInt32(Console.ReadLine());
        Greeting(name, age);
        
        // Example 3: Getting a return value from another method
        Console.Write("Enter the first number: ");
        double num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double num2 = Convert.ToInt32(Console.ReadLine());
        
        double area = Area(num1, num2);
        Console.WriteLine($"The result of {num1} * {num2} : {area}cm");
        
        // Example 4: Using Method overloading
        double total = Multiply(2, 3, 4);
        Console.WriteLine(total);
        
        // Example 5: params keyword/keyword args
        double subtotal = Checkout(1,2,3,4);
        Console.WriteLine($"The total sum is ${Math.Round(subtotal,2)}");
    }

    // Declaring a method to be called from the main method
    static void SayHello()
    {
        Console.WriteLine("Hello World!");
        Console.WriteLine("This is a method!");
        Console.WriteLine("Invoking me, saves time!");
        Console.WriteLine("I reduce repetition!");
        Console.WriteLine("Use me!");
    }

    // Passing in an argument into a function. Parameters in a function can be renamed within the method.
    static void Greeting(string name,  int age)
    {
        Console.WriteLine($"Hello {name}! I see you are {age} years old.");
    }
    
    // Return - Returns data back to where the method/function is invoked
    // Method type has to reflect the type of data being returned
    // Else if nothing is being returned, use void
    static double Area(double num1, double num2)
    {
        return num1 * num2;
    }
    
    // Method overloading - Methods can share the same name but different parameters
    //                    - Name + parameter = signature
    //                    - Methods must have a unique signature
    //                    - Depends on what is being invoked
    static double Multiply(double x, double y)
    {
        return x * y;
    }
    static double Multiply(double x, double y, double z)
    {
        return x * y * z;
    }
    
    // Example 5: params keyword - A method parameter that takes a variable number of arguments
    //                           - Parameter type must be a single - dimensional array
    //                           - Cleaner than method overloading
    static double Checkout(params double[] prices)
    {
        double total = 0;
        foreach (double price in prices)
        {
            total += price;
        }

        return total;
    }
    
}