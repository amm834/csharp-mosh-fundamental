var hour = 24;
if (hour > 0 && hour < 12)
    Console.WriteLine("It's morning");
else if (hour is >= 12 and < 18)
    Console.WriteLine("It's afternoon");
else
    Console.WriteLine("It's evening");