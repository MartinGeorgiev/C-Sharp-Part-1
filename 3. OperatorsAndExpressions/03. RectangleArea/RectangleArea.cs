using System;

class RectangleArea
{
    static void Main()
    {
        Console.WriteLine("Rectangle area calculation.");
        Console.Write("Width: ");
        float width = Convert.ToSingle(Console.ReadLine());

        Console.Write("Heigh: ");
        float height = Convert.ToSingle(Console.ReadLine());

        float rectangleArea = height * width;

        Console.WriteLine("Rectangle Area: " + rectangleArea);
    }
}