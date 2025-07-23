namespace c_sharp_study;

public class getterssetters
{
    /* Getters & Setters - Add security to fields by encapsulation
     *                   - Accessors found within properties
     *
     * Properties - combine aspects of both fields and methods(share name with a field)
     * Get accessor - Used to return the property value
     * Get accessor - Used to assign a new value
     * Value keyword - defines the value being assigned by the set (parameter)
     */
    static void GettersSetters(string[] args)
    {
        Truck truck = new Truck(501);
        truck.Speed = 10000000;
            
        Console.WriteLine(truck.Speed);
    }
}

class Truck
{
    private int speed;
    
    public Truck(int speed)
    {
        // Invoking the speed function to apply a getter & setter
       Speed = speed;
    }

    // Creating a property that uses a Getter & setting to apply some property
    public int Speed
    {
       get { return speed; } // read from speed;
       
       // Sets a value to speed
       set // Makes a property writable
       {
           if (value < 500)
           {
               speed = 500;
           }
           else
           {
               speed = value;
           }
       }
    }

}