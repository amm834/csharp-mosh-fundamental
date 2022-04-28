public class Person
{
    public int Age;
    public static int Some;
}

class Program
{
    public static void Main(string[] args)
    {
        var x = 1;
        Increment(x);
        Console.WriteLine(x);

        Person person = new Person()
        {
            Age = 50,
        };
        MakeOld(person);
        Console.WriteLine(person.Age);
    }

    public static void Increment(int number)
    {
        number += 10;
    }

    public static void MakeOld(Person person)
    {
        person.Age += 20;
    }
}