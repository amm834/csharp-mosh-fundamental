// Write a program and ask the user to supply a list of comma separated numbers (e.g 5, 1, 9, 2, 10). If the list is 
// empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; otherwise, display 
// the 3 smallest numbers in the list.

var numbers = new List<int>();
string[] inputString;

while (true)
{
    Console.Write("Enter comma separated numbers: ");
    var input = Console.ReadLine();

    if (!string.IsNullOrWhiteSpace(input))
    {
        inputString = input.Split(",");
        if (inputString.Length <= 5)
        {
            break;
        }
    }

    Console.WriteLine("Invalid List");
}

foreach (var s in inputString)
{
    var number = Convert.ToInt32(s);
    numbers.Add(number);
}

var smallet = new List<int>();
while (smallet.Count < 3)
{
    var min = numbers[0];

    foreach (var number in numbers)
    {
        if (number < min)
        {
            min = number;
        }
    }

    smallet.Add(min);
    numbers.Remove(min);
}

foreach (var i in smallet)
{
    Console.WriteLine(i);
}