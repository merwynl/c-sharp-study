namespace c_sharp_study;


public class arrays
{
    // Example 1: Arrays - A variable that can store multiple values.
    // Has a fixed buffer size. Fixed size can be declared.
    static void Arrays(string[] args)
    {
        // Declaring an array with a fixed size
        String[] students = new string[4];
        
        // Populating an array with elements
        students[0] = "Ken";
        students[1] = "Adam";   
        students[2] = "Sara";
        students[3] = "Joe";
        
        // Declaring an array of integers, doubles, floats & bools with a fixed size
        int[] order = new int[4];
        double[] price = new double[4];
        float[] count = new float[4];
        bool[] flag = new bool[4];
        
        // Declaring and assigning elements to an array
        String[] cars = {"Toyota", "Honda", "Nissan"};
        int[] scores = { 3, 4, 5, 6 };
        bool[] flags = {true,false,false,true};
        
        // Printing an entire array
        Console.WriteLine(cars);
        
        // Printing a specific array element
        Console.WriteLine(cars[0]);
        
        // Printing the length of an array
        Console.WriteLine(cars.Length);
        
        // Using a for loop to iterate and print each element in an array
        for (int i = 0; i < cars.Length; i++)
        {
            Console.WriteLine(cars[i]);
        }
    }

    // Example 2: 2D-arrays|Multi-dimentional arrays- Array within an array.
    // Useful if you need a grid or array of data
    static void MultidimentionalArrays(string[] args)
    {
        // Declaring 1D arrays
        String[] nissan = {"skyline", "gt-r", "days"};
        String[] toyota = {"rav4","camry", "corolla"};
        String[] honda =  {"cr-v", "civic", "accord"};

        // Declaring a 2d array
        String[,] parking_lot =
        {
            {"skyline", "gt-r", "days"},
            {"rav4","camry", "corolla"},
            {"cr-v", "civic", "accord"}
        };

        // Changing an element in a 2D array. array[column, row]
        parking_lot[1, 2] = "yaris";
        parking_lot[2, 2] = "jazz";

        // Iterates through each element within a 2D array
        foreach (string car in parking_lot)
        {
            Console.WriteLine(car);
        }
        
        // Using nested for loops to display a 2d array
        for (int i = 0; i < parking_lot.GetLength(0); i++)
        {
            for (int j = 0; j < parking_lot.GetLength(1); j++)
            {
                Console.Write(parking_lot[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}