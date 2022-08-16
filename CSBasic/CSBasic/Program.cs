using System.Text;

string name = "Imran";
var fullName = new StringBuilder(name);
Console.WriteLine(fullName);
fullName.Insert(0, "Md. ");
Console.WriteLine(fullName);
fullName.Insert(fullName.Length, " Khan");
Console.WriteLine(fullName);

fullName.Replace("Md.", "Mr.");
Console.WriteLine(fullName);

var nameString = fullName.ToString();
Console.WriteLine(nameString);

int a = 1;
int b = 5;

fullName.Remove(a, b); //removes b number of character from the index number a to a+b-1
Console.WriteLine(fullName);