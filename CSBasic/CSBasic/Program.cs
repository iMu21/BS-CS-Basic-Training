Console.WriteLine("Write down the total mark of an examination to see grade (0 to 100");

long mark = Convert.ToInt64(Console.ReadLine());

var result = mark < 30 ? "F" : mark < 40 ? "D" : mark < 50 ? "C" : mark < 60 ? "B" : mark < 70 ? "A-" : mark < 80 ? "A" : "A+";


Console.WriteLine($"Occupied grade for {mark} is {result}");