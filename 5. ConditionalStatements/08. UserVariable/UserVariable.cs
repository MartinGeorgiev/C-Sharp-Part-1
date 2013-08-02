/*Write a program that, depending on the user's choice inputs int, double or string variable.
 * If the variable is integer or double, increases it with 1. If the variable is string, 
 * appends "*" at its end. The program must show the value of that variable as a console 
 * output. Use switch statement.*/

using System;

class UserVariable
{
    static void Main()
    {
        Console.Write("Please enter something: ");
        string text = Console.ReadLine();

        int integer;
        bool isInteger = int.TryParse(text, out integer);

        if (isInteger == true) 
        {
            Console.WriteLine("It is integer: " + (integer + 1));
        }

        double number;
        bool isDouble = double.TryParse(text, out number);

        if (isDouble == true)
        {
            Console.WriteLine("It is double: " + (number + 1));
        }

        if (isInteger == false && isDouble == false)
        {
            Console.WriteLine("It is string: " + text + "*");
        }
    }
}
