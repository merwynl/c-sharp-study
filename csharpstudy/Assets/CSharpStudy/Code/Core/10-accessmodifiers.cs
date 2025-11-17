using System;

namespace CSharpStudy.Code.Core
{
    public class AccessModifiers
    {
        public class Program
        {
            private static void AccessModifiers(string[] args)
            {
                Player player1 = new Player("Player 1");
                Player player2 = new Player("Rival");
                player2.health = 200f;
                player1.Greeting();
                player1.GetHealth();
                player2.Greeting();
                player2.GetHealth();
            }

            /* Omitting an access modifier is the same as making a class or method private.
             * A good practice is to make every item private until it needs to be exposed.
             * Access modifiers reduce complexity by limiting accessibility.
             *
             * A good practice is to also be explicit with access modifiers to make the intended purpose clear.
             *
             * Other type of access modifiers exist:
             *      - public
             *      - private
             *      - protected
             *      - internal
             *      - internal protected
             *      - private protected
             *
             * https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/classes-and-structs/access-modifiers
             */
            private class Player
            {
                private string name;
                public float health = 100.0f;

                public Player(string name)
                {
                    this.name = name;
                    Console.WriteLine($"Creating player...{name}");
                }

                public void Greeting()
                {
                    Console.WriteLine($"Hello, {name}!");
                }

                public void GetHealth()
                {
                    Console.WriteLine($"{name} currently has {health} health points");
                }

            }

        }
    }  
}

