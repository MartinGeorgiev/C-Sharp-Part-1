/*Write a program that reads a number N and calculates the sum of the
 * first N members of the sequence of Fibonacci: 
 * 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, … */

using System;
using System.Numerics;

class FibonacciSum
{
    static void Main()
    {

        Console.Write("Please enter a number N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        BigInteger a = 0;
        BigInteger b = 1;
        BigInteger c;
        BigInteger sum = 1;

        for (int i = 1; i <= n-2; i++)
        {
            c = a + b;
            a = b;
            b = c;
            sum = sum + c;
        }

        Console.WriteLine("Result: " + sum);
    }
}
