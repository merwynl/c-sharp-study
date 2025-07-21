namespace c_sharp_study;

public class tostring
{
    static void ToString(string[] args)
    {
     // ToString() - Converts an object to its string representation, suitable for display

     Smartphone car = new Smartphone("Galaxy", "Samsung", "Silver", 2012);
     
     // Displays the current namespace & the type of object or class of the object
     Console.WriteLine(car.ToString());
     
    }
}

class Smartphone
{
    string model;
    string brand;
    string color;
    int year;

    public Smartphone(string model, string brand, string color, int year)
    {
        this.model = model;
        this.brand = brand;
        this.color = color;
        this.year = year;
    }

    // Overwriting the ToString method to return some data from an inherited class
    public override string ToString()
    {
        return $"This is a {year} {color} {model} from {brand}.";
    }
}