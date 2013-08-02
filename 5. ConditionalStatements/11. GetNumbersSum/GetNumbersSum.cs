/*Бях сгрещил задачата в предната лекция, поради тази причина тук посочвам правилното решение*/

/*Write a program that gets a number n and after that gets more n 
 * numbers and calculates and prints their sum. */

using System;

class GetNumbersSum
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int sum = 0;

        for (int i = 1; i <= number; i++)
        {
            int secondNumber = Convert.ToInt32(Console.ReadLine());
            sum = sum + secondNumber;
        }
        Console.WriteLine("Result: " + sum);
    }
}
