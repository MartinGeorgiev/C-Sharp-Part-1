using System;

class SumNumbers
{
    static void Main()
    {
        int sum = 0;

        for (int i = 0; i < int.MaxValue;)
        {
            Console.Write("Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            sum = sum + number;
            Console.WriteLine("Sum: " + sum);
        }
    }
}