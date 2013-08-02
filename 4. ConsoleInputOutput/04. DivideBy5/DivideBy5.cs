/*Write a program that reads two positive integer numbers 
 * and prints how many numbers p exist between them such that 
 * the reminder of the division by 5 is 0 (inclusive). 
 * Example: p(17,25) = 2.*/

using System;

class DivideBy5
{
    static void Main()
    {
        Console.Write("First number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        for (int i = firstNumber; i <= secondNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Result: " + i);
            }

        }
    }
}