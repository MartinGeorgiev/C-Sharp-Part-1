//Write a program that calculates the greatest common divisor (GCD) of given two numbers. Use the Euclidean algorithm (find it in Internet).

using System;

class GreatestDivisor
{
    static void Main()
    {
 
        Console.Write("Insert the first number: ");
        int firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Insert the second number: ");
        int secondNum = Convert.ToInt32(Console.ReadLine());

        int var = 1;
        if (secondNum == 0)
        {
            Console.WriteLine("The greatest  divisor is {0}", firstNum);
        }
        else if (firstNum == 0)
        {
            Console.WriteLine("The greatest  divisor is {0}", secondNum);
        }
        else
        {
            while (var != 0)
            {
                var = firstNum % secondNum;
                firstNum = secondNum;
                secondNum = var;
            }
            Console.WriteLine("The greatest  divisor is {0}", firstNum);
        }
    }
}