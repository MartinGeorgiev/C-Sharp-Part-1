//Write a program that calculates N!/K! for given N and K (1<K<N).

using System;
using System.Numerics;

class NFactorialCalculation
{
    static void Main()
    {
        Console.WriteLine("Please enter values for N and K: ");

        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.Write("K: ");
        int k = Convert.ToInt32(Console.ReadLine());

        if (n <= k)
        {
           
            while (n <= k)
            {
                Console.WriteLine("N must be greater than K. Please enter new values for N and K.");

                Console.Write("N: ");
                n = Convert.ToInt32(Console.ReadLine());

                Console.Write("K: ");
                k = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;

        for (int i = 1; i <= n; i++)
        {
            nFactorial = i * nFactorial;
        }

        for (int y = 1; y <= k; y++)
        {
            kFactorial = y * kFactorial;   
        }

        Console.WriteLine("Result: " + nFactorial/kFactorial);
    }
}