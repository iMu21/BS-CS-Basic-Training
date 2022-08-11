int a = 1;

//using do loop
do
{
    Console.Write(a + " ");
    a++;
} while (a < 10);
Console.WriteLine("\n");



/* using
 * while
 * loop */

while (a != 0)
{
    Console.Write(a + " ");
    a--;
}
Console.WriteLine("\n");

//for loop
for (int i = 0; i < 10; i++)
{
    Console.Write(i + " ");
}
Console.WriteLine("\n");


/* foreach loop */
foreach (char c in "foreach")
{
    Console.Write(c + " ");
}
Console.WriteLine("\n");

//loo[ing 1 to 99 ,skip at 95 and breaking at 99
a = 1;
while (true)
{
    if (a == 99)
    {
        Console.Write(a + "\n");
        break;
    }
    else if (a == 95)
    {
        a++;
        continue;
    }
    else
    {
        Console.Write(a + " ");
    }
    a++;
}
/// <summary>
/// Task is completed.
/// </summary>