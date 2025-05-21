using System;
using System.Text.RegularExpressions;
using System.Linq;


namespace WordCount
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any English sentence and Press enter");
            string? yourInput = Console.ReadLine().ToString();
            string[] wordsinYourInput = yourInput.Split(" ");
            Console.WriteLine("Your input Sentence: \t" + yourInput);
            Console.WriteLine("Words in the sentence are:");
            for (int i = 0; i < wordsinYourInput.Length; i++)
            {
                Console.WriteLine(wordsinYourInput[i]);
            }
            Console.WriteLine("the sentence has " + wordsinYourInput.Length + " words");
            Console.ReadLine();
        }
    }
}
