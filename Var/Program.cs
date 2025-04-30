using System;
using System.Text.RegularExpressions;
using System.Linq;
namespace Var
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
        }
    }
}
/*Console.WriteLine("Please enter your paragraph (type END on a new line to finish):");

 string yourInput = "";
 string? line;

 while ((line = Console.ReadLine()) != null && line != "END")
 {
     yourInput += line + " ";
 }

 if (string.IsNullOrWhiteSpace(yourInput))
 {
     Console.WriteLine("You did not enter any text.");
     return;
 }

 // Sentence split
 string[] sentences = yourInput.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);
 // Word split
 string[] wordsinYourInput = yourInput.Split(new[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries);

 foreach (string sentence in sentences)
 {
     string trimmedSentence = sentence.Trim();
     Console.WriteLine("\nSentence: " + trimmedSentence);

     string[] words = trimmedSentence.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
     int maxLength = 0;
     int indexOfLargest = 0;

     for (int i = 0; i < words.Length; i++)
     {
         string cleanWord = words[i].Trim(',', '.', '!', '?', '"');
         if (cleanWord.Length > maxLength)
         {
             maxLength = cleanWord.Length;
indexOfLargest = i;
         }
         Console.WriteLine(cleanWord);
     }

     string longestWord = words[indexOfLargest].Trim(',', '.', '!', '?', '"');
     Console.WriteLine("The longest word in this sentence is: " + longestWord);
 }

 Console.WriteLine("\nThe paragraph has " + sentences.Length + " sentences.");
 Console.WriteLine("The paragraph has " + wordsinYourInput.Length + " words.");
}
}
}
// Word Count and Sentence Count Example
/*using System;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter an English paragraph and press Enter:");
        string? yourInput = Console.ReadLine();

        // Split paragraph into sentences using punctuation
        string[] sentences = Regex.Split(yourInput, @"(?<=[.!?])\s+");

        Console.WriteLine("\nYour input Paragraph:\n" + yourInput);
        Console.WriteLine($"\nThe paragraph contains {sentences.Length} sentence(s).\n");

        int totalWords = 0;

        for (int i = 0; i < sentences.Length; i++)
        {
            // Clean and split sentence into words
            string cleaned = Regex.Replace(sentences[i], @"[^\w\s]", "");
            string[] words = cleaned.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            totalWords += words.Length;

            Console.WriteLine($"Sentence {i + 1}: \"{sentences[i]}\"");
            Console.WriteLine($"Number of words: {words.Length}");
            Console.WriteLine("Words:");
            foreach (string word in words)
            {
                Console.WriteLine(" - " + word);
            }
            Console.WriteLine();
        }

        Console.WriteLine($"Total number of words in the paragraph: {totalWords}");
    }
}*/
// Palindrome Number or string Example



    /*static void Main()
    {
       
        Console.Write("Enter your mark to know your grade: ");
        int mark = int.Parse(Console.ReadLine());

        string grade = calcGrade(mark);


        Console.WriteLine("Your grade is: " + grade);
    }

    static string calcGrade(int mark)
    {
        if (mark >= 90) return "A+";
        else if (mark >= 85) return "A";
        else if (mark >= 80) return "A-";
        else if (mark >= 75) return "B+";
        else if (mark >= 70) return "B";
        else if (mark >= 65) return "B-";
        else if (mark >= 60) return "C+";
        else if (mark >= 50) return "C";
        else if (mark >= 40) return "D";
        else return "F";
    }
}*/



