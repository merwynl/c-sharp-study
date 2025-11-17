using System;

namespace CSharpStudy.Code.Core
{
    class Inheritances
    {
        /* Example 1: Inheritance - One or more child classes receiving fields, methods, etc. from a common parent class
        */
        static void Inheritance(string[] args)
        {
            // Creating objects from child classes
            Knight knight = new Knight();
            Mage mage = new Mage();
            Thief thief = new Thief();
        
            Console.WriteLine(knight.walkspeed);
            Console.WriteLine(mage.spellSlot);
            knight.walk();
        }
    }
    class Character
    {
        public int walkspeed = 0;

        public void walk()
        {
            Console.WriteLine("This character is walking!"); 
        }
    }

// Child class inheriting from the parent character class
    class Knight : Character
    {
        public int spellSlot = 3;
    }

    class Thief : Character
    {
        public int spellSlot = 4;
    }

    class Mage : Character
    {
        public int spellSlot = 8;
    }
}
