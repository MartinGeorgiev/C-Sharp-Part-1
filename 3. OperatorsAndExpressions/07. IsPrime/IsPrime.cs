using System;

class IsPrime
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        double numberSqrt = Math.Sqrt(number);

        bool isPrime = false;

        for (int i = 2; i < numberSqrt; i++)
        {
            if (number % i == 0)
            {
                isPrime = true;
                break;
            }
            else
            {
                isPrime = false;
            }
        }
        Console.WriteLine(isPrime == true ? "The number is not Prime." : "The number is Prime.");
    }
}