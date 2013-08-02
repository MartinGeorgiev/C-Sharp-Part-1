/*Write a program that shows the sign (+ or -) of the product 
 * of three real numbers without calculating it. 
 * Use a sequence of if statements.*/

using System;

class ThreeNumbersSign
{
    static void Main()
    {
        Console.WriteLine("Please enter three integers.");

        Console.Write("First number: ");
        int firstNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int secondNumber = Convert.ToInt32(Console.ReadLine());

        Console.Write("Third number: ");
        int thirdNumber = Convert.ToInt32(Console.ReadLine());

        int count = 0;
        
            if (firstNumber > 0)
            {
                count++;
            }

            if (secondNumber > 0)
            {
                count++;
            }

            if (thirdNumber > 0)
            {
                count++;
            }

            if (count == 3 || count == 1)
            {
                Console.WriteLine("Result: + ");
            }
            else
            {
                Console.WriteLine("Result: - ");
            }
        }
  }

