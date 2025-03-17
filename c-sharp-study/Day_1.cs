using System;


namespace c_sharp_study
{
    class UserInputClass
    {
        
        public static int GetUserInput()
        {
            Console.WriteLine("Please enter a number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            return number;
        }
        
        public static int LinearSearchNumber()
        {
            int[] numbers = { 10, 20, 23, 45, 50, 75 };
            int n = GetUserInput();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == n)
                {
                    Console.WriteLine("Number {0} found at position {1}", numbers[i], i);
                    return 0;
                }
            }
            Console.WriteLine("Number not found.");
            return 1;
        }
        
        
        
        public static void PrintSequentialNumbers()
        {
            int size = GetUserInput();
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine(i);
            }
        }
        
        public static void PrintEvenNumbers()
        {
            int size = GetUserInput();
            for (int i = 0; i < size; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        public static void PrintOddNumbers()
        {
            int size = GetUserInput();
            for (int i = 0; i < size; i++)
            {
                if (i % 2 > 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
        
        public static void CheckPosNeg()
        {
            int size = GetUserInput();
            if (size < 0)
            {
                Console.WriteLine("You have entered a negative number");
            }
            else if (size > 0)
            {
                Console.WriteLine("You have entered a positive number");
            }
            else
            {
                {
                    Console.WriteLine("You have entered 0");
                }
            }
        }
        
        
    } 
}


