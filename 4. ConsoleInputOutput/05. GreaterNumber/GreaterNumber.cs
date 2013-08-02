// Write a program that gets two numbers from the console and prints the greater of them. Don’t use if statements.

using System;

class GreaterNumber
{
    static void Main()
    {
        Console.WriteLine("Please enter two numbers.");

        Console.Write("First Number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second Number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        bool greaterNumber = firstNumber > secondNumber;

        Console.WriteLine(greaterNumber == true ? "The greater number is: " + firstNumber : "The greater number is: " + secondNumber);

    }
}