using System;

class BitPositionP
{
    static void Main()
    {
        Console.Write("Please enter a  number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        Console.Write("Please enter a bit position: ");
        int position = Convert.ToInt32(Console.ReadLine());

        int mask = 1 << position; // ex. 0000 0001 << 2 --> 0000 0100;
        int maskAndNumber = mask & number;
        int thirdBit = maskAndNumber >> position; //ex. 0000 0100 >> 2 --> 0000 0001;
        bool bitIsZero = (thirdBit == 0);

        Console.WriteLine(bitIsZero ? "Result: True - 0" : "Result: False - 1");
    }
}