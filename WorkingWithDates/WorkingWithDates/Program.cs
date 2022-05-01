var dateTime = new DateTime(2022, 5, 1);

var now = DateTime.Now;
now.AddDays(1);
now.AddDays(-1);

Console.WriteLine(now.ToLongTimeString());
Console.WriteLine(now.ToUniversalTime());
Console.WriteLine(now.ToString("yyyy-M-d dddd"));
                                    