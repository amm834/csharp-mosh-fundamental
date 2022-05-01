using System.Text;

var builder = new StringBuilder();
builder.Append('-', 10)
    .AppendLine()
    .Append("Hello World")
    .AppendLine()
    .Append('-', 10);
                    

Console.WriteLine(builder);