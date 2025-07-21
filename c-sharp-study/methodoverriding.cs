namespace c_sharp_study;

public class methodoverriding
{
    /* Method Overriding - Provides a new version of a method inherited from a parent class
                         - Inherited method must be: abstract, virtual or already overriden
                         - Used with ToString(), polymorphism
     */
    static void MethodOverriding(string[] args)
    {
        Dog dog = new Dog();
        Cat cat = new Cat();
        
        dog.Speak();
        cat.Speak();
        
        
    }
}

class Animal // use abstract class ClassName when working with abstract classes
{
    // Applying a virtual identifier which will allow this function to be overritten in other classes.
    // public abstract void CLassName will also work but takes no function body in the base class.
    public virtual void Speak()
    {
        Console.WriteLine("Animal goes brr.");
    }
}
class Dog : Animal
{
    // Calling the same method from the base class and overriding it
    public override void Speak()
    {
        Console.WriteLine("Dog goes woof.");
    }
}
// Method inherited class does not change.
class Cat : Animal
{
    
}

