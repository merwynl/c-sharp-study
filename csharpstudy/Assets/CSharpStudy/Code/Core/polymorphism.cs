using System;

namespace CSharpStudy.Code.Core
{
    public class Polymorphisms
    {
        /* Polymorphism - Greek word that means to have "many forms or faces":
           Poly = Many
           Morphe = form
           Objects can be identified by more than one type
           Ex. A dog can be a: canine, animal, organism
         *
         */
        static void Polymorphism(string[] args)
        {
            Car car = new Car();
            Bicycle bicycle = new Bicycle();
            Airplane airplane = new Airplane();
        
            // Creating an array of different type of objects. Find the commonality
            Vehicles[] vehicles = { car, bicycle, airplane };

            foreach (Vehicles vehicle in vehicles)
            {
                vehicle.Go();
            }
        }
    }

    class Vehicles
    {
        public virtual void Go()
        {
        }
    }

    class Car : Vehicles
    {
        public override void Go()
        {
            Console.WriteLine("The car is moving!"); 
        }
    }

    class Bicycle : Vehicles
    {
        public override void Go()
        {
            Console.WriteLine("The bicycle is moving!"); 
        }
    }

    class Airplane : Vehicles
    {
        public override void Go()
        {
            Console.WriteLine("The airplane is moving!"); 
        } 
    } 
}

