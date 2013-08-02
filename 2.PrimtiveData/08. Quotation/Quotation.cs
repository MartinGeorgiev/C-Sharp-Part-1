using System;

class Quotation
{
    static void Main()
    {
        string quatation = "The \"use\" of quotations causes difficulties.";

        string quatation2 = "The \u0022use\u0022 of quotations causes difficulties.";

        Console.WriteLine(quatation);
        Console.WriteLine(quatation2);
    }
}
