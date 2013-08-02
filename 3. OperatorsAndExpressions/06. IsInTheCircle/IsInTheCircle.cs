using System;

class IsInTheCircle
{
    static void Main()
    {
        Console.Write("X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        Console.Write("Y: ");
        int y = Convert.ToInt32(Console.ReadLine());

        int result = x * x + y * y;

        if (result <= 25) // 5*5
        {
            Console.WriteLine("The points are in the circle.");
        }
        else
        {
            Console.WriteLine("The points ARE NOT in the circle.");
        }
    }
}