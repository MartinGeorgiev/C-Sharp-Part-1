/*We are given 5 integer numbers. Write a program that checks 
 * if the sum of some subset of them is 0. Example: 3, -2, 1, 1, 8  1+1-2=0.*/

using System;

class SumIsZero
{
    static void Main()
    {
        Console.WriteLine("Please enter five integers.");

        Console.Write("First number: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("Second number: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("Third number: ");
        int c = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fourth number: ");
        int d = Convert.ToInt32(Console.ReadLine());

        Console.Write("Fifth number: ");
        int e = Convert.ToInt32(Console.ReadLine());

        int count = 0;

        if (a + b + c + d + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3}, {4} is zero.", a, b, c, d, e);
            count++;
        }

        if (a + b + c + d  == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is zero.", a, b, c, d);
            count++;
        }

        if (a + b + c == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is zero.", a, b, c);
            count++;
        }

        if (a + b == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", a, b);
            count++;
        }

        if (a + c == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", a, c);
            count++;
        }

        if (a + d == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", a, d);
            count++;
        }

        if (a + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", a, e);
            count++;
        }

        if (a + b + d  == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is zero.", a, b, d);
            count++;
        }

        if (a + b + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}is zero.", a, b, e);
            count++;
        }

        if (a + b + c + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is zero.", a, b, c, e);
            count++;
        }

        if (b + c + d + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2}, {3} is zero.", b, c, d, e);
            count++;
        }

        if (b + d + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is zero.", b, d, e);
            count++;
        }

        if (b + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", b, e);
            count++;
        }

        if (b + c == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", b, c);
            count++;
        }

        if (b + d == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", b, d);
            count++;
        }

        if (c + d + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1}, {2} is zero.", c, d, e);
            count++;
        }

        if (c + d == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", c, d);
            count++;
        }

        if (c + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", c, e);
            count++;
        }

        if (d + e == 0)
        {
            Console.WriteLine("The sum of {0}, {1} is zero.", d, e);
            count++;
        }

        if (count == 0)
        {
            Console.WriteLine("There is no result.");
        }
    }
}