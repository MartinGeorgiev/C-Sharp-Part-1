﻿/*Write a program that prints all the numbers from 1 to N.*/

using System;

class NumberToN
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = Convert.ToInt32(Console.ReadLine());

        for (int i = 1; i <= number; i++)
        {
            Console.WriteLine(i);
        }
    }
}