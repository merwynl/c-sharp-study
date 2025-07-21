namespace c_sharp_study;

public class arrays
{
    // Arrays - A variable that can store multiple values.
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

    // For each loops.
    static void ForEachLoops(string[] args)
    {
        String[] students = { "Ken",  "Adam", "Sara", "Joe" };
        for (int i = 0; i < students.Length; i++)
        {
            Console.WriteLine(students[i]);
        }
        
        // Different way of writing forloops though it's less flexible than a standard for loop
        // Can't be incremented/decremented upon.
        foreach (string student in students)
        {
            Console.WriteLine(student);
        }
    }
    
}