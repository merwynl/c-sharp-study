using System;

namespace CSharpStudy.Code.Core
{
    public class Conditionals
{
    // Conditional If statements
    static void IfStatements(string[] args)
    {
        bool isStudent = false;

        // Simple if statement
        if (isStudent)
        {
            Console.WriteLine("学生いです");
        }
        else
        {
            Console.WriteLine("学生ではありません。");
        }

        // Checking if a value is greater than
        Console.Write("年齢を入力してください: ");
        int age = Convert.ToInt32(Console.ReadLine());
        if (age >= 18)
        {
            Console.WriteLine("あなたは社会人です。お酒を買わられます。");
        }
        else
        {
            Console.WriteLine("お酒飲むは禁止されています。");
        }

        // Chaining if else statements
        Console.Write("Please enter a desired time slot(in hrs): ");
        int time = Convert.ToInt32(Console.ReadLine());
        if (time >= 19)
        {
            Console.WriteLine(
                "Reserved seating has been sold out. You may purchase tickets for general standing admission tickets.");
        }
        else if (time <= 0)
        {
            Console.WriteLine("Time slot invalid. Please try again.");
        }
        else
        {
            Console.WriteLine("There are still available reserved seating.");
        }

        // Using equal sign to check a boole condition
        Console.Write("お部屋でご掃除をいかがでしょうか？ (はい/いいえ): ");
        String response = Console.ReadLine();
        if (response == "はい" || response == "Yes" || response == "y")
        {
            Console.WriteLine("かしこまりました！明日11時頃お部屋を掃除いたします。");
        }
        else if (response == "いいえ" || response == "No" || response == "n")
        {
            Console.WriteLine("承知いたします！ごゆっくりお過ごしください！");
        }

        // If statement to check if a given string is valid using comparison operators
        Console.Write("お客様のお名前ここで入力してください:　");
        String name = Console.ReadLine();
        if (name == "" || name == " ")
        {
            Console.Write("大変申し訳ございませんです！お客様のお名前がご存在しません。もう一度入お客様の名前をご確認ください。");
        }
        else
        {
            // Using string formatting to return a provided user input
            Console.WriteLine(String.Format("お客様のお名前が確認しました{0}様、東京ホテルへようこそ。ごゆっくりどうぞ。", name));
        }

        // Checking for equality
        int period = 2025;
        if (1 == 1)
        {
            Console.WriteLine("Inside if!");
        }

        // Else statements
        bool isPlayer = true;
        if (isPlayer)
        {
            Console.WriteLine("Inside if!");
        }
        else
        {
            {
                Console.WriteLine("Inside else!");
            }
        }

        // Using the is not or ! logical operator
        if (!isPlayer)
        {
            Console.WriteLine("Oops!");
        }

        // && And logical operator
        if (age > 15 && age < 25)
        {
            Console.WriteLine("Inside If!");
        }

        // || Or logical operator
        if (age > 15 || age < 25)
        {
            Console.WriteLine("Inside If!");
        }

        // Chaining multiple logical operators
        bool isPlayer2 = false;
        if (false || false)
        {
            Console.WriteLine("Inside if!");
        }

        // If statements evaluate from left to write, parenthesis first.
        if ((1 < 2) && (5 > 1))
        {
            Console.WriteLine("Inside if!");
        }

        // Shorthand if statement for checking bool values
        bool forSale = false;
        if (forSale)
        {
            Console.WriteLine("承知いたします。レジ袋いかがでしょうか？");
        }
        else
        {
            Console.WriteLine("大変申し訳ございませんです！この商品は非常品です！");
        }

        // Another simple if statement:
        bool smokingPermitted = false;
        if (smokingPermitted)
        {
            Console.WriteLine("このエリアでの喫煙は許可されていおります。");
        }
        else
        {
            Console.WriteLine("大変申し訳ございませんです！このエリアが禁煙しております。");
        }
    }

    // Switches - Similar to MatchCase statements in Python
    static void Switches(string args)
    {
        Console.WriteLine("今日な何日ですか？");
        String day = Console.ReadLine();

        switch (day)
        {
            case "月曜日":
                Console.WriteLine("月曜日です。");
                break;
            case "火曜日":
                Console.WriteLine("火曜日です。");
                break;
            case "水曜日":
                Console.WriteLine("水曜日です。");
                break;
            case "木曜日":
                Console.WriteLine("木曜日です。");
                break;
            case "金曜日":
                Console.WriteLine("金曜日です。");
                break;
            default:
                Console.WriteLine(day + " is not a day");
                break;
        }
    }

    // Logical Operators - Check to see if more than 1 condition is true/false
    static void LogicalOperators(string args)
    {
        Console.WriteLine("What's the temperature outside?(c): ");
        double temperature = Convert.ToDouble(Console.ReadLine());

        if (temperature >= 16 && temperature <= 24)
        {
            Console.WriteLine("It's nice outside.");
        }

        else if (temperature <= -50 || temperature >= 50)
        {
            Console.WriteLine("DO NOT GO OUTSIDE!");
        }
    }
}
}

