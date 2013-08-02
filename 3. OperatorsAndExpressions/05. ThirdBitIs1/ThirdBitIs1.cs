using System;

class ThirdBitIs1
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        int mask = 8; //0000 1000 - the bit 3 is 1;

        int result = mask & number; //checking if the third bit is 1 or 0; 

        if (result == 8) //0000 1000 - the bit 3 is 1;
        {
            Console.WriteLine("The third bit is 1.");
        }
        else //.. or not.
        {
            Console.WriteLine("The third bit is 0.");
        }
    }
}