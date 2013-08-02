/*Write a program that, for a given two integer numbers N and X, 
 * calculates the sumS = 1 + 1!/X + 2!/X2 + … + N!/XN */

using System;
using System.Numerics;

class CalculateSumFactorial
{
    static void Main()
    {
        Console.WriteLine("Please enter values for N and X: ");

        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("X: ");
        int x = Convert.ToInt32(Console.ReadLine());

        double factorial = 1;
        double sum = 1;
        double variable = 1;
        double result = 0;

        for (int i = 1; i <= n; i++)
        {
            factorial = factorial * i;
            variable = Math.Pow(x, i);
            result = factorial / variable;
            sum = sum + result;
        }

        Console.WriteLine(sum);
    }
}
