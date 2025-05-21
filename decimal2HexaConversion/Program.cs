namespace FOZ
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string multiLineString = @"verbatim string not only help you keep text format as is but also 
allow you write multi-line code አሁን ባለፈው ምን ሆነ መሰላችሁ
አንድ ግለሰብ ከመሬት ተነስቶ ተቀመጠ";

            Console.WriteLine(multiLineString);

            //Console.WriteLine("Hello, World!");
            int decimalNotation = 2_000_000;
            int binaryNotation = 0b_0001_1110_1000_0100_1000_0000; // start with 0b  binary  
            int hexadecimalNotation = 0x_001E_8480; // start with 0x  hexadecimal
                                                    // Check the three variables have the same value.
            Console.WriteLine($"{decimalNotation == binaryNotation}");
            Console.WriteLine(
            $"{decimalNotation == hexadecimalNotation}");
            // Output the variable values in decimal.
            Console.WriteLine($"{decimalNotation:N0}");
            Console.WriteLine($"{binaryNotation:N0}");
            Console.WriteLine($"{hexadecimalNotation:N0}");
            // Output the variable values in hexadecimal.
            Console.WriteLine($"{decimalNotation:X}");
            Console.WriteLine($"{binaryNotation:X}");
            Console.WriteLine($"{hexadecimalNotation:X}");

            //Console.WriteLine();
            Console.ReadLine();
        }
        
    }
}
