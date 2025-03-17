using System;

namespace c_sharp_study
{
    class MainProgram
    {
        // Main Method
        public static void Main(String[] args)
        {
            int[] numbers = {2, 15, 1, 30, 4, 15, 80};
            
            // Linear search numbers
            // LinearSearchNumbers(numbers);
            
            // Linear search strings
            // Console.WriteLine("Please enter a token: ");
            // string keyString = Console.ReadLine(); 
            // string[] tokens = {"battleship", "boots", "cannon", "iron", "thimble", "top hat"};
            //
            // if (keyString == null)
            // {
            //     Console.WriteLine("Nothing entered");
            // }
            // else
            // {
            //     LinearSearchStrings(tokens,keyString);
            // }
        
            // Binary search numbers
            // Console.WriteLine("Please enter a number: ");
            // int key = Convert.ToInt32(Console.ReadLine());
            // int result = BinarySearchNumbers(numbers, key, 0, numbers.Length - 1);
            //
            // if (result == -1)
            // {
            //     Console.WriteLine("Number not found");
            // }
            // else
            // {
            //     {
            //         Console.WriteLine($"The entered number {key} found.");   
            //     }
            // }
            
            // Bubble Sort
            // BubbleSort(numbers, numbers.Length - 1);
            
            // Bubble Sort Optimized
            BubbleSortOptimized(numbers, numbers.Length - 1);

        }
        public static int LinearSearchNumbers(int[] array)
        {
            int arrayLength = array.Length;
            int key = c_sharp_study.UserInputClass.GetUserInput();
            for (int i = 0; i < arrayLength; i++)
            {
                if (array[i] == key)
                {
                    Console.WriteLine($"The number {key} is {array[i]}");
                    return 0;
                }
            }
            Console.WriteLine("Number not found!");
            return 1;
        }

        public static void LinearSearchStrings(string[] array, string key)
        {
            int arrayLength = array.Length;
            for (int i = 0; i < arrayLength; i++)
            {
                if (String.Equals(key, array[i].ToString()))
                {
                    Console.WriteLine($"Token {key} found at position {i}");
                    return;
                }
            }
            Console.WriteLine("Token not found!");
        }

        public static int BinarySearchNumbers(int[] array, int key, int left, int right)
        {
            int middle = left + (right - left) / 2;
            if (left > right)
            {
                return -1;
            }
            if (array[middle] == key)
            {
                return middle;
            }
            else if (array[middle] > key)
            {
                return BinarySearchNumbers(array, key, left, middle - 1);
            }
            else if (array[middle] < key)
            {
                return BinarySearchNumbers(array, key, middle + 1, right);
            }
            return 0;
        }

        public static int BubbleSort(int[] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < (size-1) ; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                    }
                }
            }
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Numbers [{i}]: {array[i]}");
            }
            return 0;
        }

        public static int BubbleSortOptimized(int[] array, int size)
        {
            bool swapped = false;
            int i = 0;
            do {
                swapped = false;
                for (int j = 0; j < (size-1 - i) ; j++)
                {
                    if (array[j] > array[j + 1])
                    {
                        int temp = array[j];
                        array[j] = array[j + 1];
                        array[j + 1] = temp;
                        swapped = true;
                    }
                }
                i++;
            } while (swapped);
            for (i = 0; i < size; i++)
            {
                Console.WriteLine($"Numbers [{i}]: {array[i]}");
            }
            return 0;
        }
    }
}
