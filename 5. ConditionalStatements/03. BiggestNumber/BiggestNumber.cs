/*Write a program that finds the biggest of
 * three integers using nested if statements.*/

using System;

class BiggestNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter three integers.");

        Console.Write("First number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Third number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        if(firstNumber > (Math.Max(secondNumber, thirdNumber)))
        {
            Console.WriteLine("The biggest number is " + firstNumber);
        }

        if(secondNumber > (Math.Max(firstNumber, thirdNumber)))
        {
            Console.WriteLine("The biggest number is " + secondNumber);
        }

        if(thirdNumber > (Math.Max(firstNumber, secondNumber)))
        {
            Console.WriteLine("The biggest number is " + thirdNumber);
        }

    }
}
