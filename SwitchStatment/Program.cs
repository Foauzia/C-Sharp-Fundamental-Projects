using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.OutputEncoding = System.Text.Encoding.UTF8;

        Console.Write("Enter a number: ");
        string input = Console.ReadLine();

        // Check if the input is a valid number
        if (!int.TryParse(input, out int number) || number < 0)
        {
            Console.WriteLine("Please enter a valid non-negative integer.");
            return;
        }

        int originalNumber = number;
        int numberOfDigits = input.Length;
        int sum = 0;

        // Calculate Armstrong sum
        while (number > 0)
        {
            int digit = number % 10;
            sum += (int)Math.Pow(digit, numberOfDigits);
            number /= 10;
        }

        // Display result
        if (sum == originalNumber)
        {
            Console.WriteLine($"{originalNumber} is an Armstrong number.");
        }
        else
        {
            Console.WriteLine($"{originalNumber} is not an Armstrong number.");
        }
    }
}
