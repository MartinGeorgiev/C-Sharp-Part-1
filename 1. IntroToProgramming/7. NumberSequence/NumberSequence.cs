using System;

class NumberSequence
{
    static void Main()
    {
        for (int i = 0, x = 2, y = -3; i < 5; i++)
        {
            Console.WriteLine(x);
            Console.WriteLine(y);
            x = x + 2;
            y = y - 2;
        }
    }
}