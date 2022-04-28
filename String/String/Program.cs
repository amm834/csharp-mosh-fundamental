var firstName = "Aung";
var lastName = "Myat Moe";
var fullName = firstName + " " + lastName;

var formattedName = string.Format("My name is {0} {1}", firstName, lastName);

Console.WriteLine(formattedName);

var names = new string[3]
{
    "John", "Mary", "Zery"
};

var formatedNames = string.Join(",", names);

Console.WriteLine(formatedNames);

// varbatim string

var path = @"c:\foo\bar\some.txt";

Console.WriteLine(path);