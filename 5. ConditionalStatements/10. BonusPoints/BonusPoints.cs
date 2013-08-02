/*Write a program that applies bonus scores to given scores in the range [1..9]. 
 * The program reads a digit as an input. If the digit is between 1 and 3, 
 * the program multiplies it by 10; if it is between 4 and 6, multiplies it by 100;
 * if it is between 7 and 9, multiplies it by 1000. If it is zero or if the value 
 * is not a digit, the program must report an error.*/

using System;

class BonusPoints
{
    static void Main()
    {
        Console.Write("Please enter a digit between 1 and 9: ");
        int digit = Convert.ToInt32(Console.ReadLine());

        switch (digit)
        {
            case 1: Console.WriteLine(digit * 10); break;
            case 2: Console.WriteLine(digit * 10); break;
            case 3: Console.WriteLine(digit * 10); break;
            case 4: Console.WriteLine(digit * 100); break;
            case 5: Console.WriteLine(digit * 100); break;
            case 6: Console.WriteLine(digit * 100); break;
            case 7: Console.WriteLine(digit * 1000); break;
            case 8: Console.WriteLine(digit * 1000); break;
            case 9: Console.WriteLine(digit * 1000); break;
            case 0: Console.WriteLine("Error!"); break;
            default: Console.WriteLine("Error!"); break;
        }
    }
}
