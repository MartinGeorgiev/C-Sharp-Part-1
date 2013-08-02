using System;

class NullValues
{
    static void Main()
    {
        int? firstVar = null;
        double? secondVar = null;

        Console.WriteLine(firstVar);
        Console.WriteLine(secondVar);

        Console.WriteLine(firstVar + 5);
        Console.WriteLine(secondVar + 10);
    }
}