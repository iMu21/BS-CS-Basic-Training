int[] intArray = { 34, 53, 56, -56, 746, 56, -43, 343, 44, 2, 234, 45, -1 };
string[] stringArray = { "md", "imran", "khan" };
double[] doubleArray = { 56.2, 7.87, 34.23, 78.3 };


Console.WriteLine($"Number of element in intArray: {intArray.Length}");
printIntArray(intArray);
intArray = intArray.Where(item => item > 0).ToArray();
Console.WriteLine("Removing all negative values:");
printIntArray(intArray);

Array.Reverse(intArray);
Console.WriteLine("Reversing array:");
printIntArray(intArray);

Array.Sort(intArray);
Console.WriteLine("Sorting array:");
printIntArray(intArray);

Console.WriteLine($"Number of element in stringArray: {stringArray.Length}");
printStringArray(stringArray);

Console.WriteLine($"Number of element in doubleArray: {doubleArray.Length}");
printDoubleArray(doubleArray);


void printIntArray(int[] intArray)
{
    foreach (int i in intArray)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("\n");
}

void printStringArray(string[] stringArray)
{
    foreach (string i in stringArray)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("\n");
}

void printDoubleArray(double[] doubleArray)
{
    foreach (double i in doubleArray)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("\n");
}
