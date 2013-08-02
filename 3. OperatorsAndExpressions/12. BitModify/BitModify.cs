using System;

class BitModify
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter a value - 1 or 0: ");
        int value = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter a position: ");
        int position = Convert.ToInt32(Console.ReadLine());

        int mask = 1 << position;
        int maskAndNumber;

        if (value == 1)
        {
            maskAndNumber = number | mask;
        }
        else
        {
            maskAndNumber = number & ~mask;
        }

        Console.WriteLine(maskAndNumber);
        
    }
}