//Write a program that finds the greatest of given 5 variables.

using System;

class GreatestNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter five integers.");

        Console.Write("First number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Third number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fourth number: ");
        int fourthNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fifth number: ");
        int fifthNumber = Convert.ToInt32(Console.ReadLine());

        int maxValue1 = Math.Max(firstNumber, secondNumber);
        int maxValue2 = Math.Max(thirdNumber, fourthNumber);
        int maxValue3 = Math.Max(maxValue1, maxValue2);
        int greatestNumber = Math.Max(maxValue3, fifthNumber);

        Console.WriteLine(greatestNumber);

    }
}
