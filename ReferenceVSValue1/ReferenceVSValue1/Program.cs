var a = 10;
var b = a;
b++;

// copy value same as other langs 
Console.WriteLine(string.Format("a: {0}, b: {1}", a, b));

var x = new int[3] {0, 1, 2};
var y = x;
y[0] = 200;

// reference type sharing same memoryK address
Console.WriteLine("x[0]: {0}, y[0]: {1}", x[0], y[0]);