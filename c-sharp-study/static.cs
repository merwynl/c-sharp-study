namespace c_sharp_study;

class staticModifiers
{
    /* Example 1: Static: - A modifier to declare a static member which belongs to the class itself
*                         - rather than to any specific object
     *                      
     */
    static void StaticModifiers(string[] args)
    {
        Cars car1 = new Cars("Toyota");
        Cars car2 = new Cars("Lexus");
        Cars car3 = new Cars("Hyundai");
        
        // Accessing a public non-static field.
        Console.WriteLine(car1.model);
        
        // car1.numberofCars; can no longer be accessed from the object itself because numberofCars is static.  
        Console.WriteLine(Cars.numberofCars);
        
        // Invoking a public method
        Cars.StartRace();
    }
}

class Cars
{
    public String model;
    public static int numberofCars;
    // Creating a constructor
    public Cars (String model)
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