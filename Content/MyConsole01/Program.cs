// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, MyConsole01!");

double[] array = new double[] { 1.2, 3, 2 };
var sum = 0.0;
if (array.Any())
    foreach (var item in array)
        sum += item;
else
    

Console.WriteLine(sum);