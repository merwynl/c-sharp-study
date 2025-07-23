namespace c_sharp_study;

public class interfaces
{
    /* interface - defines a "contract" that all classes inheriting from should follow
     *           - an interface defines "what a class should have"
     *           - an inheriting class defines "how it should do it"
     *           - benefit = security + multiple inheritance + "plug & play"
     *
     */
    static void Interfaces(string[] args)
    {
        // Creating an object from a class that inherits from an interface
        Rabbit rabbit = new Rabbit();
        rabbit.Flee();
        
        Hawk hawk = new Hawk();
        hawk.Hunt();
        
        // Creating an object that inherits from multiple interfaces.
        Fish fish = new Fish();
        fish.Flee();
        fish.Hunt();
    }
}

// Creating an interface. Common convention is to prefix the name of the interface with "I"
interface IPrey
{
    // Declaring a method to be used by a glass. Functionality defined within class itself.
    void Flee()
    {
        
    }
}

interface IPredator
{
    void Hunt()
    {
        
    }
}

class Rabbit: IPrey
{
    public void Flee()
    {
        Console.WriteLine("Rabbit runs away!");
    }
}

class Hawk: IPredator
{
    public void Hunt()
    {
        Console.WriteLine("Hawk is hunting!");
    }
}

// Unlike standard inheritance, classes can inherit from multiple interfaces
class Fish: IPredator, IPrey
{
    public void Hunt()
    {
        Console.WriteLine("Fish is hunting!");
    }

    public void Flee()
    {
        Console.WriteLine("Fish is fleeing!");
    }

}