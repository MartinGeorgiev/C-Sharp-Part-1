using System;

class IsFemale
{
    static void Main()
    {
        Console.Write("Your gender - male or female: ");
        string gender = Console.ReadLine();

        bool isFemale = (gender == "female");

        Console.WriteLine("Result: " + isFemale);
    }
}