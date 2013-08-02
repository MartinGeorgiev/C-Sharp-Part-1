using System;

class ThirdDigitIs7
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int firstDigit = number / 10;
        int secondDigit = firstDigit / 10;

        int thirdDigit = secondDigit % 10;

        if (thirdDigit == 7)
        {
            Console.WriteLine("Result: True. The third digit is 7.");
        }
        else
        {
            Console.WriteLine("Result: False. The third digit is NOT 7.");
        }    
    }
}