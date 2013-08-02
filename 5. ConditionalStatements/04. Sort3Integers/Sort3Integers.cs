//Sort 3 real values in descending order using nested if statements.

using System;

class Sort3Integers
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

        int big = 0;
        int bigger = 0;
        int biggest = 0;

        if ((firstNumber > secondNumber) && (secondNumber > thirdNumber)) 
        {
            biggest = firstNumber;
            bigger = secondNumber;
            big = thirdNumber;
        }

        if ((secondNumber > thirdNumber) && (secondNumber > firstNumber) && (firstNumber > thirdNumber))
        {
            biggest = secondNumber;
            bigger = firstNumber;
            big = thirdNumber;
        }

        if ((firstNumber < secondNumber) && (secondNumber < thirdNumber))        
        {
            biggest = thirdNumber;
            bigger = secondNumber;
            big = firstNumber;
        }

        if ((secondNumber > thirdNumber) && (secondNumber > firstNumber) && (firstNumber < thirdNumber))
        {
            biggest = secondNumber;
            bigger = thirdNumber;
            big = firstNumber;
        }

        if ((secondNumber < thirdNumber) && (secondNumber < firstNumber) && (firstNumber < thirdNumber))
        {
            biggest = thirdNumber;
            bigger = firstNumber;
            big = secondNumber;
        }

        if ((secondNumber < thirdNumber) && (secondNumber < firstNumber) && (firstNumber > thirdNumber))
        {
            biggest = firstNumber;
            bigger = thirdNumber;
            big = secondNumber;
        }

        Console.WriteLine(biggest);
        Console.WriteLine(bigger);
        Console.WriteLine(big);
    }
}
