var random = new Random();
const int passwordLength = 10;

var buffer = new char[passwordLength];
for (var i = 0; i < passwordLength; i++)
{
    buffer[i] = (char) ((int) 'a' + random.Next(1, 26));
}

var password = new string(buffer);
Console.WriteLine(password);