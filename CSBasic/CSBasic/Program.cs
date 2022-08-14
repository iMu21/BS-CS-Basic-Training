List<int> intList = new List<int>();
List<String> stringList = new List<String>();
List<double> doubleList = new List<double>();

intList.Add(67);
intList.Add(21);
intList.Add(65);
intList.Add(34);
intList.Add(65);
intList.Add(-65);
intList.Add(-5);
intList.Add(35);
intList.Add(-165);
intList.Add(675);


printIntList(intList);

Console.WriteLine($"Capacity of the array intList: {intList.Capacity}\n");

Console.WriteLine($"Number of element in the array intList: {intList.Count}\n");

Console.WriteLine("Before:");
printIntList(intList);

intList[4] = 45;
intList[1] = 78;
Console.WriteLine("After changing value of index 1 & 4:");
printIntList(intList);

intList.RemoveAt(1);
Console.WriteLine("After removing value of index 1:");
printIntList(intList);

intList.RemoveAll(item => item < 0);
Console.WriteLine("Removing all negative values:");
printIntList(intList);

intList.Reverse();
Console.WriteLine("Reversing the list:");
printIntList(intList);

intList.Sort();
Console.WriteLine("Sorting the list:");
printIntList(intList);


stringList.Add("This a string!");
stringList.Add("A string!");
stringList.Add("Another string!");
printStringList(stringList);

doubleList.Add(345.34);
doubleList.Add(45.74);
doubleList.Add(30.344);
doubleList.Add(95.24);
printDoubleList(doubleList);

void printIntList(List<int> intList)
{
    foreach (int i in intList)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("\n");
}

void printStringList(List<string> stringList)
{
    foreach (string i in stringList)
    {
        Console.WriteLine(i);
    }
    Console.WriteLine("\n");
}

void printDoubleList(List<double> doubleList)
{
    foreach (double i in doubleList)
    {
        Console.Write(i + " ");
    }
    Console.WriteLine("\n");
}