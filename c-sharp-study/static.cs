namespace c_sharp_study;

class staticModifiers
{
    /* Example 1: Static: - A modifier to declare a static member which belongs to the class itself
*                         - rather than to any specific object
     *                      
     */
    static void StaticModifiers(string[] args)
    {
        Car car1 = new Car("Toyota");
        Car car2 = new Car("Lexus");
        Car car3 = new Car("Hyundai");
        
        // Accessing a public non-static field.
        Console.WriteLine(car1.model);
        
        // car1.numberofCars; can no longer be accessed from the object itself because numberofCars is static.  
        Console.WriteLine(Car.numberofCars);
        
        // Invoking a public method
        Car.StartRace();
    }
}

class Car
{
    public String model;
    public static int numberofCars;
    // Creating a constructor
    public Car(String model)
    {
        this.model = model;
        numberofCars ++; // Each time an object is instantiated, we increment by 1.
    }

    // Creating a public static method. All objects will have access to this method
    public static void StartRace()
    {
        Console.WriteLine("The race has now begun!");
    }
}