namespace c_sharp_study;

public class enums
{
    /* Enums - Special class that contains a set of named integer constants
     *       - Use enums when you have values that you know will not change
     *       - To get the integer value from an item, you must explicitly convert to an int
     *
     *       - name = integer
     */
    static void Enums(string[] args)
    {
        
        // Printing the specific enum name, not the index or int value
        // No different to using the ToString method
        Console.WriteLine(Planets.Pluto + " is a planet");
        
        // Casting a named enum member to an int to get the int value
        Console.WriteLine(Planets.Pluto + " is planet #" + (int)Planets.Pluto);
        
        //
        String name = PlanetRadius.Earth.ToString();
        int radius = (int)PlanetRadius.Earth;
        double volume = GetPlanetVolume(PlanetRadius.Earth);
        
        Console.WriteLine("Planet: " + name + " is "+ radius +"kms wide");
        Console.WriteLine("Planet: " + name + " is " + volume + " km^3");
        
    }

    static double GetPlanetVolume(PlanetRadius radius)
    {
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow((int)radius, 3);
        return volume;
    }
    
    // Declaring an enum. Members start at index 0 if no index is specified
    enum Planets
    {
        Mercury = 1, 
        Venus = 6, 
        Mars = 8, 
        Jupiter = 7, 
        Earth = 3, 
        Uranus = 4, 
        Neptune = 5, 
        Pluto = 2, 
        Saturn = 10
    }

    enum PlanetRadius
    {
        Mercury = 2439, 
        Venus = 6051, 
        Mars = 3389, 
        Jupiter = 669911, 
        Earth = 6371, 
        Uranus = 25362, 
        Neptune = 24622, 
        Pluto = 1188, 
        Saturn = 58232
    }
}
