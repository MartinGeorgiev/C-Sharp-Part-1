/*Write an if statement that examines two integer variables 
 * and exchanges their values if the first one is greater 
 * than the second one.*/

using System;

class ExchangeValues
{
    static void Main()
    {
        Console.WriteLine("Please enter two integers.");

        Console.Write("First number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        if (firstNumber > secondNumber)
        {
            secondNumber = firstNumber + secondNumber;
            firstNumber = secondNumber - firstNumber;
            secondNumber = secondNumber - firstNumber;

            Console.WriteLine("After exchange.");
            Console.WriteLine("First number: " + firstNumber);
            Console.WriteLine("Second number: " + secondNumber);
        }

        else
        {
            Console.WriteLine("There is no exchange.");
        }
    }
}
