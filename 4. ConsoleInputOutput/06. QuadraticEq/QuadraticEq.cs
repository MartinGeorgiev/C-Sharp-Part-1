/*Write a program that reads the coefficients a, b and c of a 
 * quadratic equation ax2+bx+c=0 and solves it (prints its real roots).*/

using System;

class QuadraticEq
{
    static void Main()
    {
        Console.Write("A: ");
        int a = Convert.ToInt32(Console.ReadLine());

        Console.Write("B: ");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.Write("C: ");
        int c = Convert.ToInt32(Console.ReadLine());

        double x1;
        double x2;

        double delta = b * b - 4 * a * c;

        if (delta > 0)
        {
            x1 = (-b + Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);
            x2 = (-b - Math.Sqrt(Math.Pow(b, 2) - 4 * a * c)) / (2 * a);

            Console.WriteLine(x1);
            Console.WriteLine(x2);
        }

        if (delta == 0)
        {
            x1 = -b/(2*a);
            Console.WriteLine("x1 = x2 = " + x1);
        }
        
        if(delta < 0 )
        {
            Console.WriteLine("There are no real roots.");
        }



    }
}