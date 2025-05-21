using System;

namespace DateConverterApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a Gregorian date (yyyy-MM-dd): ");
            string input = Console.ReadLine();

            if (string.IsNullOrEmpty(input) || !DateTime.TryParse(input, out DateTime gregorianDate))
            {
                Console.WriteLine("Invalid date. Please enter a valid Gregorian date (e.g., 2023-09-11).");
                Console.WriteLine("\nPress any key to exit...");
                Console.ReadKey();
                return;
            }

            EthiopianDate ethiopianDate = ConvertToEthiopian(gregorianDate);

            Console.WriteLine($"\nGregorian Date: {gregorianDate:yyyy-MM-dd} ({gregorianDate.DayOfWeek})");
            Console.WriteLine($"Ethiopian Date: {ethiopianDate.Year}-{ethiopianDate.Month:D2}-{ethiopianDate.Day:D2}");

            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }

        public static EthiopianDate ConvertToEthiopian(DateTime gregDate)
        {
            int ethYear;
            DateTime ethNewYear;

            // Pagume 
            int newYearDay = DateTime.IsLeapYear(gregDate.Year - 1) ? 12 : 11;
            ethNewYear = new DateTime(gregDate.Year, 9, newYearDay);

            // Adjust for the Ethiopian New Year
            if (gregDate < ethNewYear)
            {
                ethYear = gregDate.Year - 8;
                ethNewYear = new DateTime(gregDate.Year - 1, 9, DateTime.IsLeapYear(gregDate.Year - 2) ? 12 : 11);
            }
            else
            {
                ethYear = gregDate.Year - 7;
            }

            int daysSinceNewYear = (gregDate - ethNewYear).Days;

            int ethMonth = (daysSinceNewYear / 30) + 1;
            int ethDay = (daysSinceNewYear % 30) + 1;

            return new EthiopianDate(ethYear, ethMonth, ethDay);
        }
    }

    public class EthiopianDate
    {
        public int Year { get; set; }
        public int Month { get; set; }
        public int Day { get; set; }

        public EthiopianDate(int year, int month, int day)
        {
            Year = year;
            Month = month;
            Day = day;
        }
    }
}
