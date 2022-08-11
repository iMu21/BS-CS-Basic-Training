class Car
{
    string color;
    int price;
    string name;


    public Car(string name, string color, int price)
    {
        this.name = name;
        this.color = color;
        this.price = price;
    }

    public void changeColor(string color)
    {
        this.color = color;
        Console.WriteLine("\nColor has been changed!");
    }

    public void changeName(string name)
    {
        this.name = name;
        Console.WriteLine("\nName has been changed!");
    }

    public void changePrice(int price)
    {
        this.price = price;
        Console.WriteLine("\nPrice has been changed!");
    }
    static void Main(string[] args)
    {
        Car object1 = new Car("Tesla", "Black", 367376);
        Console.WriteLine(object1.name);
        Console.WriteLine(object1.color);
        Console.WriteLine(object1.price);

        object1.changeColor("Red");
        Console.WriteLine(object1.name);
        Console.WriteLine(object1.color);
        Console.WriteLine(object1.price);

        object1.changeName("Pajero");
        Console.WriteLine(object1.name);
        Console.WriteLine(object1.color);
        Console.WriteLine(object1.price);

        object1.changePrice(878786);
        Console.WriteLine(object1.name);
        Console.WriteLine(object1.color);
        Console.WriteLine(object1.price);
    }
}