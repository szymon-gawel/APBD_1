// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Mod1");

Console.WriteLine("Mod2");

Console.WriteLine("Mod3");

static double GetAverage(int[] numbers)
{
    var sum = 0;

    foreach (var number in numbers)
    {
        sum += number;
    }

    return sum / numbers.Length;
}