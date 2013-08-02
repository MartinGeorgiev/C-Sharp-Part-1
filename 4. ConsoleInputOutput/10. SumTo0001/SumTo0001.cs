/*Write a program to calculate the sum (with accuracy of 0.001):
 * 1 + 1/2 - 1/3 + 1/4 - 1/5 + ... */

using System;

class SumTo0001
{
    static void Main()
    {
        double sum = 1;

        for (double i = 2; i <= 1000; i++)
        {
            if(i % 2 == 0)
            {
                sum = sum + 1/i;
            }
            else
            {
                sum = sum - 1/i;
            }
        }
        Console.WriteLine("Result: " + sum);
    }
}
