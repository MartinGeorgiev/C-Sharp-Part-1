using System;

class Triangle
{
    static void Main()
    {
        string firstRowSpace = new String(' ', 2);
        string firstRowChar = new String('\u00A9', 1);

        string secondRowSpace = new String(' ', 1);
        string secondRowChar = new String('\u00A9', 3);

        string thirdRowSpace = new String(' ', 0);
        string thirdRowChar = new String('\u00A9', 5);

        Console.WriteLine(firstRowSpace + firstRowChar);
        Console.WriteLine(secondRowSpace + secondRowChar);
        Console.WriteLine(thirdRowSpace + thirdRowChar);
    }
}
    