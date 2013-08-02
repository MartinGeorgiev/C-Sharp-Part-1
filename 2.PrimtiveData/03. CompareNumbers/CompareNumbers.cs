using System;

class CompareNumbers
{
    static void Main()
    {
        Console.Write("First number: ");
        decimal firstNumber = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Second number: ");
        decimal secondNumber = Convert.ToDecimal(Console.ReadLine());

        decimal difference = Math.Abs(firstNumber - secondNumber);

        if (difference <= 0.000001m)
        {
            Console.WriteLine("Result: True");
        }
        else
        {
            Console.WriteLine("Result: False");
        }
    }
}
