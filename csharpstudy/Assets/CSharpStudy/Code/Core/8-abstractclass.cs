using System;

namespace CSharpStudy.Code.Core
{
    public class AbstractClasses
    {
        /* Abstract class - Modifier that indicates missing components or incomplete implementation
        */
        static void AbstractClass(string[] args)
        {
            Train train = new Train();
            Boat boat = new Boat();
            Bike bike = new Bike();
        
            // This object can no longer be created because it has missing variables from other classes.
            // Vehicle vehicle = new Vehicle();
        }
    }

    abstract class Vehicle
    {
        public int speed = 0;

        public void go()
        {
            Console.WriteLine("This vehicle is going!");
        }
    }

// Child class inheriting from the parent character class
    class Train : Vehicle
    {
        public int wheel = 20;
        private int maxSpeed = 700;
    }

    class Boat : Vehicle
    {
        public int wheel = 0;
        private int maxSpeed = 450;
    }

    class Bike : Vehicle
    {
        public int wheel = 2;
        private int maxSpeed = 200;
    } 
}

