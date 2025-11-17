using System;

/*
 * Single responsibility principle - A function or class should only serve and do one thing only
 * Arbitrary situation but if a code/script contains > 500 lines, there's potentially room for improvement
 * Group related logic/data together. e.g: Creating a separate type or struct for gathering PlayerStats
 * Avoid magic numbers.
 * Reduce complexity by limiting accessibility.
 * Reduce comments - Code should be self-documenting.
 * Don't repeat code - If ypu find yourself using a snippet more than 3 times, put them into a function.
 * Constantly refactor code.
 * Keep functions short & concise.
 * Never use strings as identifiers - Put them into a constant var then reference that var.
 * It's fine to use var to inherit the type but try to be a little more explicit where possible.
 */

namespace CSharpStudy.Code.Core
{
    // Classes: PascalCase
    public class CodeStyle
    {
        // Classes: PascalCase
        private class Player
        {
            // Constants: UpperCase SNAKE_CASE
            private const int CONSTANT_FIELD = 56;
            private const string DEBUG_COMMAND = "DEBUG";

            // Properties : PascaleCase
            private static CodeStyle Instance { get; set; }

            // Private Fields : PascalCase appended by underscore
            private float _SomeField;

            // Public Fields : PascalCase
            private float SomeVariable;

            // Static fields : camelCase
            private static float currentScore;

            // Events : PascalCase
            private EventHandler OnSomethingHappened;

            // Constructors : PascalCase
            public Player()
            {
                Console.WriteLine($"Some printout...{SomeVariable}");
            }

            // Class methods : PascalCase
            public float DoSomething(float health)
            {
                _SomeField = 10f;
                float score = currentScore;
                if (health < _SomeField)
                {
                    // Do something else
                    Console.WriteLine(" ");
                }

                return score;
            }
        }

        // Function names : PascalCase
        private void SomeFunction()
        {
            Player player1 = new Player();
            player1.DoSomething(10f);
        }

        // Function parameters : camelCase
        private void SomeOtherFunction(float health)
        {
            Player player2 = new Player();
            player2.DoSomething(health);
        }

    }

}