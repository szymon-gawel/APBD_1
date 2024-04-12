// See https://aka.ms/new-console-template for more information

Console.WriteLine("Hello, World!");

Console.WriteLine("Mod1");

Console.WriteLine("Mod2");

Console.WriteLine("Mod3");

static double GetAverage(int[] numbers)
{
    var sum_conflict = 0;

    foreach (var number in numbers)
    {
        sum_conflict += number;
    }

    return sum_conflict / numbers.Length;
}

static int GetMax(int[] numbers)
{
    var max = 0;
    
    foreach (var number in numbers)
    {
        if (number > max)
            max = number;
    }

    return max;
}