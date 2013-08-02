//Write a program that calculates N!*K! / (K-N)! for given N and K (1<N<K).

using System;
using System.Numerics;

class NFactorialCalculation2
{
    static void Main()
    {
        Console.WriteLine("Please enter values for K and N: ");

        Console.Write("K: ");
        int k = Convert.ToInt32(Console.ReadLine());

        Console.Write("N: ");
        int n = Convert.ToInt32(Console.ReadLine());

        if (k <= n)
        {
           
            while (k <= n)
            {
                Console.WriteLine("K must be greater than N. Please enter new values for K and N.");

                Console.Write("K: ");
                k = Convert.ToInt32(Console.ReadLine());

                Console.Write("N: ");
                n = Convert.ToInt32(Console.ReadLine());
            }
        }
        
        BigInteger nFactorial = 1;
        BigInteger kFactorial = 1;
        BigInteger kMinusNFactorial = 1;

        for (int i = 1; i <= k; i++)
        {
            nFactorial = i * nFactorial;
        }

        for (int y = 1; y <= n; y++)
        {
            kFactorial = y * kFactorial;   
        }

        for (int z = 1; z <= (k - n); z++)
		{
			 kMinusNFactorial = kMinusNFactorial * z;
		}

        BigInteger nKFakctorial = nFactorial * kFactorial;
        BigInteger result = nKFakctorial/kMinusNFactorial;
        Console.WriteLine("Result: " + result);
    }
}
   