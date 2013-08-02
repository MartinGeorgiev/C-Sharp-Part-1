//Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following:


using System;

class NumberSeq
{
    static void Main()
    {
        Console.Write("Please enter a number N: ");
        int n = Convert.ToInt32(Console.ReadLine());
       
        for (int i = 0; i < n; i++)
        {
            for (int y = 1 + i; y <= n + i; y++)
            {
                Console.Write(y + " ");
            }
            Console.WriteLine();
        }
    }
}
