/*Write a program that reads an integer number n from the console 
 * and prints all the numbers in the interval [1..n], each on a single line.*/

using System;

class NumberToN
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}
