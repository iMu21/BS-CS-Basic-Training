int maxInteger = int.MaxValue;
int number1 = 30;
int number2 = 1234;

try
{
    checked
    {
        var number = number1 + maxInteger;
    }
}
catch (OverflowException e)
{
    Console.WriteLine($"{number1} + {maxInteger} " + e.Message);
}

try
{
    checked
    {
        var number = number1 + number2;
        Console.WriteLine($"{number1} + {number2} = {number}");
    }
}
catch (OverflowException e)
{
    Console.WriteLine(e.Message);
}