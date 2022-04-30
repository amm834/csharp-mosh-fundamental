// 1- Write a program and ask the user to enter a number. The number should be between 1 to 10.
// If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". (This logic is used a lot in applications where values entered into input boxes need to be validated.)

while (true)
{
    try
    {
        Console.Write("Enter number between 1 to 10: ");

        var input = Console.ReadLine();
        if (String.IsNullOrWhiteSpace(input))
        {
            Console.WriteLine("Invalid");
        }

        var inputNumber = int.Parse(input);
        if (inputNumber >= 1 && inputNumber <= 10)
        {
            Console.WriteLine("Valid");
        }
        else
        {
            Console.WriteLine("Invalid");
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Please enter only number");
    }
}