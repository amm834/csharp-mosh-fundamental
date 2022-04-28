public enum Languages
{
    HTML,
    CSS,
    JS
}

class Program
{
    public static void Main(string[] args)
    {
        // int type 
        var js = (int) Languages.JS;
        Console.WriteLine(js);

        var languageNumber = 2;
        Console.WriteLine((Languages) languageNumber);

        var jsString = "JS";
        Console.WriteLine((int)Enum.Parse(typeof(Languages), jsString));
    }
}