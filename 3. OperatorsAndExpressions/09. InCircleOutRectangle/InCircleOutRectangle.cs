using System;

class InCircleOutOfRectangle
{
    static void Main()
    {
        Console.WriteLine("Please enter values for x and y.");
        Console.Write("X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        bool isInTheRectangle;
        bool isInTheCircle;

        if((x >= 1 && x <= 7) && (y <= -1 && y >= -3))
        {
            isInTheRectangle = true;
        }
        else
        {
            isInTheRectangle = false;
        }

        if (x * x + y * y <= 3 * 3)
        {
            isInTheCircle = true;
        }
        else
        {
            isInTheCircle = false;
        }

        if ((isInTheCircle == true) && (isInTheRectangle == false))
        {
            Console.WriteLine("The point is in the circle and out of the rectangle.");
        }
        else
        {
            Console.WriteLine("Result: False.");
        }

    }
}