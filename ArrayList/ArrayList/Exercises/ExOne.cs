namespace ArrayList.Exercises;

public class ExOne
{
    public ExOne()
    {
/*
 *1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays different information.

If no one likes your post, it doesn't display anything.
If only one person likes your post, it displays: [Friend's Name] likes your post.
If two people like your post, it displays: [Friend 1] and [Friend 2] like your post.
If more than two people like your post, it displays: [Friend 1], [Friend 2] and [Number of Other People] others like your post.
Write a program and continuously ask the user to enter different names, until the user presses Enter (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.
 */

        var names = new List<string>();

        while (true)
        {
            Console.Write("Enter your friend list: ");
            var nameInput = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(nameInput))
            {
                names.Add(nameInput);
            }
            else
            {
                var totalLike = names.Count;
                if (totalLike == 1)
                {
                    Console.WriteLine(names[0] + " likes your post");
                }

                if (totalLike == 2)
                {
                    Console.WriteLine("{0} and {1}  likes your post", names[0], names[1]);
                }

                if (totalLike >= 3)
                {
                    Console.WriteLine("{0}, {1} and {2} likes your post", names[0], names[1], totalLike - 2);
                }

                break;
            }
        }
    }

    public void exTwo()
    {
// // 2- Write a program and ask the user to enter their name. Use an array to reverse the name and then store the result in a new string. Display the reversed name on the console.
//


        Console.Write("Enter your name: ");
        var name = Console.ReadLine();
        var array = new char[name.Length];
        for (var i = name.Length; i > 0; i--)
        {
            array[name.Length - i] = name[i - 1];
        }

        var newName = new string(array);
        Console.WriteLine(newName);
    }

    public void exthree()
    {
        /// <summary>
        /// Write a program and ask the user to enter 5 numbers. If a number has been previously entered, display 
        /// an error message and ask the user to re-try. Once the user successfully enters 5 unique numbers, sort them 
        /// and display the result on the console.
        /// </summary>
        ///
        ///

        var uniqueNumbers = new List<int>();

        while (true)
        {
            Console.Write("Enter unique number: ");
            var input = Console.ReadLine();
            var uniqueNumber = int.Parse(input);

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter valid number");
                continue;
            }

            if (uniqueNumbers.Contains(uniqueNumber))
            {
                Console.WriteLine(
                    "Please enter unique number that's not exist in the number list that you had entered.");
                continue;
            }
            else
            {
                uniqueNumbers.Add(uniqueNumber);
            }

            if (uniqueNumbers.Count == 5)
            {
                break;
            }
        }

        Console.WriteLine(string.Join(",", uniqueNumbers));
    }

    public void exfour()
    {
        /// <summary>
        /// Write a program and ask the user to continuously enter a number or type "Quit" to exit. The list of numbers may 
        /// include duplicates. Display the unique numbers that the user has entered.
        /// </summary>


        var msg = @"
Enter the list of number and type ':q' to exist
";
        Console.WriteLine(msg);

        var numbers = new List<int>();
        string input;
        do
        {
            Console.Write("Enter numbers: ");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input))
            {
                try
                {
                    var number = int.Parse(input);
                    numbers.Add(number);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Please enter valid number ");
                    continue;
                }
            }
        } while (input != ":q");

        var uniques = new List<int>();
        foreach (var number in numbers)
        {
            if (!uniques.Contains(number))
            {
                uniques.Add(number);
            }
        }

        foreach (var unique in uniques)
        {
            Console.WriteLine(unique);
        }
    }
}