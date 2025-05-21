/*using System;

namespace Days
{
    class Program
    {
        static void Main(string[] args)
        {
            
            DateTime defaultDate = new DateTime();
            Console.WriteLine("Default Date: " + defaultDate.ToString());

            
            DateTime today = DateTime.Now;
            TimeSpan oneDay = TimeSpan.FromDays(1);
            DateTime tomorrow = today + oneDay;

            Console.WriteLine("Today: " + today.ToString());
            Console.WriteLine("Tomorrow: " + tomorrow.ToString());

            
            DateTime specificDate = new DateTime(2024, 11, 18);
            DateTime specificDateTime = new DateTime(2024, 11, 18, 14, 30, 0);

            Console.WriteLine("Specific Date: " + specificDate.ToString());
            Console.WriteLine("Specific DateTime: " + specificDateTime.ToString());
        }
    }
}*/

using System;

namespace DateTimeFormatsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            DateTime utcNow = DateTime.UtcNow;

            Console.WriteLine("=== DateTime Outputs ===");
            Console.WriteLine("Short date: " + now.ToString("d"));
            Console.WriteLine("Long date: " + now.ToString("D"));
            Console.WriteLine("Short time: " + now.ToString("t"));
            Console.WriteLine("Long time: " + now.ToString("T"));
            Console.WriteLine("Full date (short time): " + now.ToString("f"));
            Console.WriteLine("Full date (long time): " + now.ToString("F"));
            Console.WriteLine("Round-trip format: " + now.ToString("o"));

           
            Console.WriteLine("UTC Now: " + utcNow.ToString("F"));

         
            Console.WriteLine("\nPress any key to exit...");
            Console.ReadKey();
        }
    }
}
