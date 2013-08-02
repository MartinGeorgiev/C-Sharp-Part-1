/*Write a program that prints all the numbers from 1 to N, 
 * that are not divisible by 3 and 7 at the same time.*/

using System;

class DivideBy3and7
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());
            
        for (int i = 1; i <= number; i++)
        {
            if (i % 21 != 0)
            {
                Console.WriteLine(i);
            }
        }   

    }
}

