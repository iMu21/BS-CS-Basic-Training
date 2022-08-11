Console.WriteLine("Input to numbers:\n");

long a = Convert.ToInt64(Console.ReadLine());
long b = Convert.ToInt64(Console.ReadLine());

Console.WriteLine($"Summation of {a} and {b},\n {a} + {b} = {sumOfTwoNumber(a, b)}\n");
Console.WriteLine($"Subtract of {a} and {b},\n {a} - {b} = {subOfTwoNumber(a, b)}\n");
Console.WriteLine($"Multiplication of {a} and {b},\n {a} * {b} = {multOfTwoNumber(a, b)}\n");
Console.WriteLine($"Divition of {a} by {b},\n {a} / {b} = {divOfTwoNumber(a, b)}\n");
Console.WriteLine($"Mod of {a} by {b},\n {a} % {b} = {modOfTwoNumber(a, b)}\n");
Console.WriteLine($"Binary OR of {a} and {b},\n {a} | {b} = {binaryOrOfTwoNumber(a, b)}\n");
Console.WriteLine($"Binary XOR of {a} and {b},\n {a} ^ {b} = {binaryXorOfTwoNumber(a, b)}\n");
Console.WriteLine($"Binary AND of {a} and {b},\n {a} & {b} = {binaryAndOfTwoNumber(a, b)}\n");

long sumOfTwoNumber(long num1, long num2)
{
    return num1 + num2;
}

long subOfTwoNumber(long num1, long num2)
{
    return num1 - num2;
}

long multOfTwoNumber(long num1, long num2)
{
    return num1 * num2;
}

long divOfTwoNumber(long num1, long num2)
{
    return num1 / num2;
}

long modOfTwoNumber(long num1, long num2)
{
    return num1 % num2;
}

long binaryOrOfTwoNumber(long num1, long num2)
{
    return num1 | num2;
}

long binaryAndOfTwoNumber(long num1, long num2)
{
    return num1 & num2;
}

long binaryXorOfTwoNumber(long num1, long num2)
{
    return num1 ^ num2;
}

