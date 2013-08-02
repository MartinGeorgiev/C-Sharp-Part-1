using System;

class After10Years
{
    static void Main()
    {
        Console.Write("Age: ");
        int ageNow = Convert.ToInt16(Console.ReadLine());
        
        Console.WriteLine("After 10 years I will be " + (ageNow + 10) + " years old!");
    }
}