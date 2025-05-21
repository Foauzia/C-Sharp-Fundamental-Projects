using System;

namespace RandomNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Random.Shared.Next(minValue: 1, maxValue: 7);
            Console.WriteLine($"My random number is {number}");

            switch (number)
            {
                case 1:
                    Console.WriteLine("One");
                    break;
                case 2:
                    Console.WriteLine("Two");
                    goto case 1;
                case 3:
                case 4:
                    Console.WriteLine("Three or four");
                    goto case 1;
                case 5:
                    goto A_label;
                default:
                    Console.WriteLine("Default");
                    break;
            }

            Console.WriteLine("After end of switch");

        A_label:
            Console.WriteLine("After A_label");
           

            // Multi-line verbatim string
            string multiLineString = @"verbatim string not only helps you keep text format as-is but also 
                                    allows you to write multi-line code አሁን ባለፈው ምን ሆነ መሰላችሁ
                                    አንድ ግለሰብ ከመሬት ተነስቶ ተቀመጠ";
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine();
            Console.WriteLine(multiLineString);
            Console.ReadLine();
        }
    }
}
