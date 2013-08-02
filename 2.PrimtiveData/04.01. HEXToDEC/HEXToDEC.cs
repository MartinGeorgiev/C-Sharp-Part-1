using System;

class HEXToDec
{
    static void Main()
    {
        Console.Write("HEX value: ");
        string HEXValue = Console.ReadLine();

        int decimalValue = Convert.ToInt32(HEXValue, 16);

        Console.WriteLine("Decimal value: " + decimalValue);
    }
}