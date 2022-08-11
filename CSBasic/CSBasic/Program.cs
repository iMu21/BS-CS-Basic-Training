public struct Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public int Age { get; set; }
    public string FatherName { get; set; }

    public void getValue(int id, string name, int age, string father)
    {
        Id = id;
        Name = name;
        Age = age;
        FatherName = father;
    }

    public void display()
    {
        Console.WriteLine($"Student Id: = {Id}");
        Console.WriteLine($"Student Name: = {Name}");
        Console.WriteLine($"Student Age: = {Age}");
        Console.WriteLine($"Student Father's Name: = {FatherName}");
    }

};

public class testStructure
{
    public static void Main(string[] args)
    {
        Student student1 = new Student();
        student1.getValue(1, "Md Imran Khan", 25, "Shahidul Islam Khan");
        student1.display();
    }
}