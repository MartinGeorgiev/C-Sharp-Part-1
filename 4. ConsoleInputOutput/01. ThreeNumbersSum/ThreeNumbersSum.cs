//Write a program that reads 3 integer numbers from the console and prints their sum.

using System;

class ThreeNumbersSum
{
    static void Main()
	{
        Console.WriteLine("Please enter three numbers.");
		
        Console.Write("First Number: ");
		int firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Second Number: ");
		int secondNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Third Number: ");
		int thirdNumber = Convert.ToInt32(Console.ReadLine());
		
		int sum = firstNumber + secondNumber + thirdNumber;

        Console.WriteLine("The sum of three number is: " + sum);
	}
}