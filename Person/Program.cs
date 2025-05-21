using System;
using System.Collections.Generic;

namespace Love
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Please enter your paragraph(s) (type END on a new line to finish):");

            List<string> paragraphs = new List<string>();
            string? line;
            string currentParagraph = "";

            while ((line = Console.ReadLine()) != null && line != "END")
            {
                if (string.IsNullOrWhiteSpace(line))
                {
                    if (!string.IsNullOrWhiteSpace(currentParagraph))
                    {
                        paragraphs.Add(currentParagraph.Trim());
                        currentParagraph = "";
                    }
                }
                else
                {
                    currentParagraph += line + " ";
                }
            }

            if (!string.IsNullOrWhiteSpace(currentParagraph))
            {
                paragraphs.Add(currentParagraph.Trim());
            }

            if (paragraphs.Count == 0)
            {
                Console.WriteLine("You did not enter any paragraph.");
                return;
            }

            int totalWords = 0;
            int totalSentences = 0;

            for (int p = 0; p < paragraphs.Count; p++)
            {
                Console.WriteLine($"\nParagraph {p + 1}:");
                string paragraph = paragraphs[p];

                // Split into sentences using punctuation
                string[] sentences = paragraph.Split(new[] { '.', '?', '!' }, StringSplitOptions.RemoveEmptyEntries);
                totalSentences += sentences.Length;

                foreach (string sentence in sentences)
                {
                    string trimmed = sentence.Trim();
                    Console.WriteLine("\nSentence: " + trimmed);

                    string[] words = trimmed.Split(new[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);
                    totalWords += words.Length;

                    // Find longest word
                    string longestWord = "";
                    foreach (var word in words)
                    {
                        string cleanWord = word.Trim(',', '.', '!', '?', '"', ';', ':');
                        if (cleanWord.Length > longestWord.Length)
                        {
                            longestWord = cleanWord;
                        }
                        Console.WriteLine(cleanWord);
                    }

                    Console.WriteLine("Longest word: " + longestWord);
                }
            }

            Console.WriteLine($"\nTotal paragraphs: {paragraphs.Count}");
            Console.WriteLine($"Total sentences in the paragraph is: {totalSentences  }");
            Console.WriteLine($"Total words in the sentences is: {totalWords}");

            Console.ReadLine();
        }
    }
}
