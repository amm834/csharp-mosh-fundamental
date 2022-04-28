using IfElseSwitch;

var language = Languages.JS;
switch (language)
{
    case Languages.JS:
        Console.WriteLine("Messy language");
        break;
    case Languages.HTML:
        Console.WriteLine("Master of WWW");
        break;
    case Languages.CSS:
        Console.WriteLine("Master of beatuiful websites");
        break;
    default:
        Console.WriteLine("I don't know");
        break;
}