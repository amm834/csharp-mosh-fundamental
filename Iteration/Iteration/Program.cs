while (true)
{
    Console.Write("Enter your name: ");
    var input = Console.ReadLine();
    if (!String.IsNullOrWhiteSpace(input))
    {
        Console.WriteLine("@Echo {0}", input);
        continue;
    }
    break;
}