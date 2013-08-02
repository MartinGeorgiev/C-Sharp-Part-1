using System;

class PrintNumbers
{
    static void Main()
    {
        Console.Write("Write number: ");
        int cycleNumber = Convert.ToInt32(Console.ReadLine());

        int firstNumber = 1;
        Console.WriteLine(firstNumber);

        for (int i = 2; i <= cycleNumber; i++)
        {   
            double result = Math.Pow(10,i);
            Console.WriteLine(result + 1);
        }

    }
}
