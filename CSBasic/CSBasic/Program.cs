class Food
{
    public string Name;
    public int Price;

    public Food(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void get_value(string name, int price)
    {
        this.Name = name;
        this.Price = price;
    }

    public void display()
    {
        Console.WriteLine($"Food name = {Name}");
        Console.WriteLine($"Food price = {Price}\n");
    }
}

public class FoodRepresentation
{
    public static void Main(string[] args)
    {
        Food food1 = new Food("Berger", 150);
        Food food2 = food1;

        food1.display();
        food2.display();

        food2.get_value("Pizza", 500);

        food1.display();
        food2.display();

        int a = 50;
        int b = a;

        Console.WriteLine($"a = {a}\nb = {b}\n");

        b = 60;

        Console.WriteLine($"a = {a}\nb = {b}\n");
    }
}