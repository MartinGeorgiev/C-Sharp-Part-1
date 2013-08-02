using System;

class CompanyInfo
{
    static void Main()
    {
        Console.WriteLine("Please enter information about your company.");
        Console.Write("Company name: ");
        string companyName = Console.ReadLine();

        Console.Write("Company address: ");
        string companyAddress = Console.ReadLine();

        Console.Write("Company phone: ");
        int companyPhone = Convert.ToInt32(Console.ReadLine());

        Console.Write("Company fax: ");
        int companyFax = Convert.ToInt32(Console.ReadLine());

        Console.Write("Company website: ");
        string companyWebSite = Console.ReadLine();

        Console.Write("Company manager: ");
        string companyManager = Console.ReadLine();

        Console.WriteLine("Company name: " + companyName);
        Console.WriteLine("Company address: " + companyAddress);
        Console.WriteLine("Company phone: " + companyPhone);
        Console.WriteLine("Company fax: " + companyFax);
        Console.WriteLine("Company website: " + companyWebSite);
        Console.WriteLine("Company manager: " + companyManager);
    }
}