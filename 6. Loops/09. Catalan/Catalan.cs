/* 09. In the combinatorial mathematics, the Catalan numbers are calculated by the following formula:
 * (2*n)! / (n + 1)! * n!Write a program to calculate the Nth Catalan number by given N. */

using System;

class Catalan
{
    static void Main()
    {

        Console.Write("n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int middle = 1;
        decimal result = 1;

        int n1 = n + 1;
        for (int i = 2 * n; i > n1; i--)
        {
            middle *= i;
        }

        result = result * middle;
        
        for (int i = 1; i <= n; i++)
        {
            result /= i;
        }

        Console.WriteLine(result);
    }
}