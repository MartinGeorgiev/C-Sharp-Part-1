//Write a program that reads the radius r of a circle and prints its perimeter and area.

using System;

class CircleAreaAndPerimeter
{
    static void Main()
    {
        Console.Write("Please enter a circle radius value: ");
        double circleRadius = Convert.ToSingle(Console.ReadLine());

        double circleArea = circleRadius * circleRadius * Math.PI;
        double circlePeremeter = 2 * circleRadius * Math.PI;

        Console.WriteLine("Circle`s area: " + circleArea);
        Console.WriteLine("Circle`s peremeter: " + circlePeremeter);
    }
}
