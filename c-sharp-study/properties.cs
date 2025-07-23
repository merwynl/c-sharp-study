namespace c_sharp_study;

public class properties
{
    /* Auto implemented properties - Shortcuts when no additional logic is required in the property
     *                             - You do not have to define a field for a property
     *                             - You only have to get; and/or set; inside the property
     */
    static void Properties(string[] args)
    {
        Plane plane = new Plane("Airbus A340");
        // Fruit fruit = new Fruit("Apple");
        
        Console.WriteLine(plane.Model);
    }
}

class Plane
{
    // Shorthand of declaring a property if there are no specific functionality or logic required.
    public String Model { get; set; }
    
    public Plane(String model)
    {
       this.Model = model; 
    }
}

// Creating a class of type Book with a property of author
class Book
{
    string author;
    string title;
    int publishedYear;
    string publisher;

    // Creating properties with getters and setters
    public string Author
    {
        get { return author; }
        set { author = value; }
    }
    public String Title
    {
        get { return title; }
    }
    
    // Declaring auto properties
    public int PublishedYear { get; set;}
    public string Publisher { get; set; }
    
    public Book(string author,  string title, int publishedYear, string publisher)
    {
        this.Author = author;
        this.PublishedYear = publishedYear;
        this.Publisher = publisher;
    }
}