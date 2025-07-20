namespace c_sharp_study;

public class Loops
{
    // While loops - While a condition is true/false do something
    static void WhileLoops(string[] args)
    { 
        string name = ""; 
        while (name == "")
        {
            Console.WriteLine("Enter your name: ");  
            name = Console.ReadLine(); 
        }
        
        Console.WriteLine(String.Format("Hello {0}!", name));
    }

    // Do While loops - Do something until a condition is no longer true
    static void DoWhileLoop(string[] args)
    {
        int i = 0, j = 10, result;
        do
        {
            result = i += 1;
            Console.WriteLine(result);
        }while (i<j);
    }
    
    // For Loops
    static void ForLoops(string[] args)
    {
        // For loops in c# require a counter, a condition and an increment
        for (int i = 1; i < 21; i+=4)
        {
            Console.WriteLine(i);
        }
    }

    // Nested Loops - Loops inside another loop. Used a lot in sorting algorithms
    static void NestedLoops(string[] args)
    {
        Console.Write("How many rows? ");
        int rows = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("How many columns? ");
        int columns = Convert.ToInt32(Console.ReadLine());
        
        Console.Write("What symbol or char? ");
        string symbol = Console.ReadLine();
        
        for (int i = 0; i <= rows; i++)
        {
            for (int j = 0; j <= columns; j++)
            {
                Console.Write(symbol);
            }
            Console.WriteLine();
        }
        
    }
    static void Main(string[] args)
    {
        NestedLoops(args);
        Console.ReadKey();
    }
}