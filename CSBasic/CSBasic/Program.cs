DateTime today = DateTime.Now;

Console.WriteLine($"Today {today.ToString()}");
Console.WriteLine("Today is {0:dddd}\n", today);

Console.WriteLine($"Minimum DateTime value is {DateTime.MinValue}");
Console.WriteLine($"Maximum DateTime value is {DateTime.MaxValue}");
Console.WriteLine($"Universal time is now {DateTime.UtcNow}\n");

TimeSpan duration = new TimeSpan(23, 67, 32, 23); // day-hour-min-sec
DateTime lastDay = today.Add(duration);
Console.WriteLine(lastDay.ToString());

DateTime date1 = new DateTime(2022, 7, 19, 9, 56, 12);
DateTime date2 = new DateTime(2022, 10, 12, 15, 54, 32);
TimeSpan difference = date2.Subtract(date1);

Console.WriteLine($"\nDifference between\n{date1}\n&\n{date2} is\n{difference.Days} days {difference.Hours} hours {difference.Minutes} minutes and {difference.Seconds} seconds.");