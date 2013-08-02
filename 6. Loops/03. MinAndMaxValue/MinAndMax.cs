/*Write a program that reads from the console a sequence of N
 * integer numbers and returns the minimal and maximal of them. */

using System;

class MinAndMaxValue
{
    static void Main()
    {
        Console.Write("Please enter a number N: ");
        int number = Convert.ToInt32(Console.ReadLine());
        int a = 0;
        int minValue = int.MaxValue;
        int maxValue = int.MinValue;

        for (int i = 1; i <= number; i++)
        {
            int nextNumber = Convert.ToInt32(Console.ReadLine());
            a = nextNumber;

            if (a > maxValue)
            {
                maxValue = a;
            }

            if (a < minValue)
            {
                minValue = a;
            }
        }
        Console.WriteLine("Max Value: " + maxValue);
        Console.WriteLine("Min Value: "  + minValue);
    }
}
