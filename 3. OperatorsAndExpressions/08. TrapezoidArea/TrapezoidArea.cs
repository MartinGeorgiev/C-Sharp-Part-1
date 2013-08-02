using System;

class TrapezoidArea
{
    static void Main()
    {
        Console.WriteLine("Trapezoid area calculation.");
        Console.Write("A: ");
        float a = Convert.ToSingle(Console.ReadLine());

        Console.Write("B: ");
        float b = Convert.ToSingle(Console.ReadLine());

        Console.Write("H: ");
        float height = Convert.ToSingle(Console.ReadLine());

        float trapezoidArea = (width * width2 * height) / 2;

        Console.WriteLine("Trapezoid area: " + trapezoidArea);
    }
}