using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        Console.WriteLine("Select conversion mode:");
        Console.WriteLine("ET2G - Ethiopian to Gregorian");
        Console.WriteLine("G2ET - Gregorian to Ethiopian");
        Console.Write("Enter selection (E for ET2G or G for G2ET): ");
        char mode = char.ToUpper(Console.ReadKey().KeyChar);
        Console.WriteLine();

        Console.Write("Enter date (yyyy-MM-dd): ");
        string input = Console.ReadLine();

        if (!DateTime.TryParseExact(input, "yyyy-MM-dd", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime inputDate))
        {
            Console.WriteLine("Invalid date format. Please use yyyy-MM-dd.");
            return;
        }

        if (mode == 'E')
        {
            DateTime converted = EthiopianToGregorian(inputDate);
            Console.WriteLine("Gregorian Equivalent: " + converted.ToString("yyyy-MM-dd"));
        }
        else if (mode == 'G')
        {
            DateTime converted = GregorianToEthiopian(inputDate);
            Console.WriteLine("Ethiopian Equivalent: " + converted.ToString("yyyy-MM-dd"));
        }
        else
        {
            Console.WriteLine("Invalid selection. Please enter 'E' or 'G'.");
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static DateTime EthiopianToGregorian(DateTime etDate)
    {
        int year = etDate.Year + 8;
        DateTime newYear = new DateTime(year, 9, 11);
        if (DateTime.IsLeapYear(year)) newYear = newYear.AddDays(1);

        return newYear.AddDays((etDate - new DateTime(etDate.Year, 1, 1)).Days);
    }

    static DateTime GregorianToEthiopian(DateTime grDate)
    {
        int year = grDate.Year - 8;
        DateTime ethNewYear = new DateTime(grDate.Year, 9, 11);
        if (DateTime.IsLeapYear(grDate.Year)) ethNewYear = ethNewYear.AddDays(1);

        if (grDate < ethNewYear)
        {
            year -= 1;
            ethNewYear = new DateTime(grDate.Year - 1, 8, 11);
            if (DateTime.IsLeapYear(grDate.Year - 1)) ethNewYear = ethNewYear.AddDays(1);
        }

        int daysFromNewYear = (grDate - ethNewYear).Days;
        return new DateTime(year, 1, 1).AddDays(daysFromNewYear);
    }
}
