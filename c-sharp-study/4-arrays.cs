namespace c_sharp_study;

public class arrays
{
    // Example 1: Arrays - A variable that can store multiple values.
    // Has a fixed buffer size. Fixed size can be declared.
    static void Arrays(string[] args)
    {
        // Declaring an array with a fixed size
        string[] students = new string[4];

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

        // Alternative method of declaring an array explicitly assigning values to it
        int[] numbers = new int[] { 23, 23, 54, 64, 13 };

        // Declaring and assigning elements to an array. If no values are assigned to the array, a size must be defined
        String[] cars = { "Toyota", "Honda", "Nissan" };
        int[] scores = { 3, 4, 5, 6 };
        bool[] flags = { true, false, false, true };

        // Printing an entire array
        Console.WriteLine(cars);

        // Printing a specific array element
        Console.WriteLine(cars[0]);

        // Printing the length or size of an array
        Console.WriteLine(scores.Length);

        // Using a for loop to iterate and print each element in an array
        for (int i = 0; i < flags.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
    }

    // Example 2: 2D-arrays|Multi-dimentional arrays are arrays within an array.
    // Useful if you need a grid or array of data
    static void MultidimentionalArrays(string[] args)
    {
        // Declaring 1D arrays
        String[] nissan = { "skyline", "gt-r", "days" };
        String[] toyota = { "rav4", "camry", "corolla" };
        String[] honda = { "cr-v", "civic", "accord" };

        // Declaring a 2d array
        String[,] parkingLot =
        {
            { "skyline", "gt-r", "days" },
            { "rav4", "camry", "corolla" },
            { "cr-v", "civic", "accord" }
        };

        // Changing an element in a 2D array. array[column, row]
        parkingLot[1, 2] = "yaris";
        parkingLot[2, 2] = "jazz";

        // Iterates through each element within a 2D array
        foreach (string car in parkingLot)
        {
            Console.WriteLine(car);
        }

        // Using nested for loops to display a 2d array
        for (int i = 0; i < parkingLot.GetLength(0); i++)
        {
            for (int j = 0; j < parkingLot.GetLength(1); j++)
            {
                Console.Write(parkingLot[i, j] + " ");
            }

            Console.WriteLine();
        }
    }
}