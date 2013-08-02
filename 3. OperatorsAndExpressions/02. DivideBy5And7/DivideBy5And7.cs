using System;

class DivideBy5And7
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        if (number % 35 == 0)
        {
            Console.WriteLine("The number can be divided by 5 and 7 without remainder.");
        }
        else
        {
            Console.WriteLine("The number CAN NOT be divided by 5 and 7 without remainder.");
        }

    }
}