using System;
using System.Numerics;

class ExchangeBits
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int maskThirdBit = number & (1 << 3);
        int maskFourthBit = number & (1 << 4);
        int maskFifthBit = number & (1 << 5);
        int thirdBit = maskThirdBit >> 3;
        int fourthBit = maskFourthBit >> 4;
        int fifthBit = maskFifthBit >> 5;

        int newNumberThirdBit;
        int newNumberFourthBit;
        int newNumberFifthBit;

        if (thirdBit == 1)
        {
            newNumberThirdBit = (thirdBit << 24) | number;
        }
        else
        {
            newNumberThirdBit = ~(thirdBit << 24) & number;
        }
        // ...............................
       
        if (fourthBit == 1)
        {
            newNumberFourthBit = (fourthBit << 25) | newNumberThirdBit;
        }
        else
        {
            newNumberFourthBit = ~(fourthBit << 25) & newNumberThirdBit;
        }

        //........................................

        if (fifthBit == 1)
        {
            newNumberFifthBit = (fifthBit << 26) | newNumberFourthBit;
        }
        else
        {
            newNumberFifthBit = ~(fifthBit << 26) & newNumberFourthBit;
        }

        Console.WriteLine(newNumberFifthBit & ~(56)); // 56 --> 0001 1100;
    }
}