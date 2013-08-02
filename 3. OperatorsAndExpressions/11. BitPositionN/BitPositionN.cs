using System;

class BitPositionN
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter a position: ");
        int position = Convert.ToInt32(Console.ReadLine());

        int mask = 1 << position; // 0000 0001 << 2 --> 0000 0100;
        int maskAndNumber = number & mask;
        int bit = maskAndNumber >> position; // 0000 0100 >> 2 --> 0000 0001;

        Console.WriteLine(bit == 1 ? "Result: 1" : "Result: 0");
    }
}