Console.WriteLine("Enter a positive number");

int number = Convert.ToInt32(Console.ReadLine());

if (isPrimeNumber(number))
{
    Console.WriteLine($"{number} is a prime number\n");
}
else
{
    Console.WriteLine($"{number} is not a prime number\n");
}



Console.WriteLine("Enter a character");
char c = Convert.ToChar(value: Console.ReadLine());

if (c >= 'a' && c <= 'z')
{
    Console.WriteLine("Small letter\n");
}
else if (c >= 'A' && c <= 'Z')
{
    Console.WriteLine("Capital letter\n");
}
else
{
    Console.WriteLine("Not a letter\n");
}

bool isPrimeNumber(long a)
{
    if (a == 1 || a == 2) return true;
    for (int i = 2; i * i <= a; i++)
    {
        if (a % i == 0) return false;
    }
    return true;

}