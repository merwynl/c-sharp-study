namespace c_sharp_study;

public class loops
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
        for (int i = 0; i < 21; i+=4)
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
    
    // Number guessing game
    static void NumberGuesser(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        int min = 1;
        int max = 100;
        int guess;
        int number;
        int guessCount;
        string response;
        
        Console.WriteLine("Welcome to Number Guesser!");

        while (playAgain)
        {
            guess = 0;
            guessCount = 0;
            number = random.Next(min, max + 1);
            response = "";
            while (guess != number)
            {
                Console.Write("Select a number between {0} and {1}: ", min,max);
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Guess: " + guess);

                if (guess > number)
                {
                    Console.WriteLine("Too high! Try again!");
                }
                else if (guess < number)
                {
                    Console.WriteLine("Too low! Try again!");
                }
                guessCount++;
            }
            Console.WriteLine("Congrats! The answer is {0}!", number);  
            Console.WriteLine("Number of guesses: {0}", guessCount);
            
            Console.WriteLine("Would you like to play again? (y/n): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        
        Console.WriteLine("Thanks for playing! Press any key to exit...");
    }
    
    // Rock-paper scissors
    static void RockPaperScissors(string[] args)
    {
        Random random = new Random();
        bool playAgain = true;
        string player;
        string computer;
        string response;
        
        while (playAgain)
        {
            player = "";
            computer = "";
            response = "";
            
            while(player != "ROCK" && player != "PAPER" && player != "SCISSORS")
            {
                Console.Write("Enter ROCK, PAPER or SCISSORS: ");
                player = Console.ReadLine();
                player = player.ToUpper();
            }

            switch (random.Next(1, 4))
            {
                case 1:
                    computer = "ROCK";
                    break;
                case 2:
                    computer = "PAPER";
                    break;
                case 3:
                    computer = "SCISSORS";
                    break;
            }      
            
            Console.WriteLine("Player: {0}", player);
            Console.WriteLine("Computer: {0}", computer);

            switch (player)
            {
                case "ROCK":
                    if (computer == "ROCK")
                    {
                       Console.WriteLine("It's a draw!"); 
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You lose!");
                    }
                    else
                    {
                        Console.WriteLine("You win!");
                    }
                    break;
                case "PAPER":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You win!"); 
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    else
                    {
                        Console.WriteLine("You lose!");
                    }
                    break;
                case "SCISSORS":
                    if (computer == "ROCK")
                    {
                        Console.WriteLine("You lose!"); 
                    }
                    else if (computer == "PAPER")
                    {
                        Console.WriteLine("You win!");
                    }
                    else
                    {
                        Console.WriteLine("It's a draw!");
                    }
                    break;
            }
            Console.WriteLine("Would you like to play again? (y/n): ");
            response = Console.ReadLine();
            response = response.ToUpper();
            if (response == "Y")
            {
                playAgain = true;
            }
            else
            {
                playAgain = false;
            }
        }
        Console.WriteLine("Thanks for playing!");
    }

    static void Calculator(string[] args)
    {
        do
        {
            double num1 = 0;
            double num2 = 0;
            string symbol;
            double result = 0;
        
            Console.WriteLine("------------------------------");
            Console.WriteLine("Welcome to Codebox Calculator!");
            Console.WriteLine("------------------------------");
       
            Console.Write("Enter the first number: ");
            num1 = Convert.ToDouble(Console.ReadLine());
       
            Console.Write("Enter the second number: ");
            num2 = Convert.ToDouble(Console.ReadLine());
       
            Console.WriteLine("Please select an operator: ");
            Console.WriteLine("\t+: Addition");
            Console.WriteLine("\t-: Subtraction");
            Console.WriteLine("\t*: Multiplication");
            Console.WriteLine("\t/: Division");
            Console.WriteLine("\t%: Modulus");

            switch (Console.ReadLine())
            {
                case "+":
                    result = num1 + num2;
                    Console.WriteLine($"Result: {num1} + {num2} = " + Math.Round(result, 2));
                    break;
                case "-":
                    result = num1 - num2;
                    Console.WriteLine($"Result: {num1} - {num2} = " + Math.Round(result, 2));
                    break;
                case "*":
                    result = num1 * num2;
                    Console.WriteLine($"Result: {num1} * {num2} = " + Math.Round(result, 2));
                    break;
                case "/":
                    result = num1 / num2;
                    Console.WriteLine($"Result: {num1} / {num2} = " + Math.Round(result, 2));
                    break;
                case "%":
                    result = num1 % num2;
                    Console.WriteLine($"Result: {num1} % {num2} = " + Math.Round(result, 2));
                    break;
                default:
                    Console.WriteLine("That is not a valid option!");
                    break;
            } 
            Console.WriteLine("Would you like to continue? (y/n): ");  
        } while (Console.ReadLine().ToUpper() == "Y");
        Console.WriteLine("Thank you! Have a nice day!");  
    }
}