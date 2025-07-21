namespace c_sharp_study;

class overloading
{
    static void Overloading(string[] args)
    {
        Pizza pizza = new Pizza("Stuffed crust", "Mozzarella", "Tomato", "Olives");
    }
}

class Pizza
{
    String bread;
    String cheese;
    String sauce;
    String topping;

    /* Example 1: Overloaded constructors - Similar to method overloading
                                          - Technique to create multiple constructors with different params
                                          - name + param = signature
                                          - Can't have two constructors with the same num of args

    */
    public Pizza(String bread)
    {
        this.bread = bread;
        this.sauce = sauce;
    }
    public Pizza(String bread, String cheese)
    {
        this.bread = bread;
        this.cheese = cheese;
    }
    public Pizza(String bread, String cheese, String sauce)
    {
        this.bread = bread;
        this.cheese = cheese;
        this.sauce = sauce;
    }
    public Pizza(String bread, String cheese, String sauce, String topping)
    {
        this.bread = bread;
        this.cheese = cheese;
        this.sauce = sauce;
        this.topping = topping;
    }
}