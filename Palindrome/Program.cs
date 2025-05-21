using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a number or string you want to check: ");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine($"{input} is a Palindrome.");
        }
        else
        {
            Console.WriteLine($"{input} is not a Palindrome.");
            SuggestLetterForPalindrome(input);
        }

        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }

    static bool IsPalindrome(string text)
    {
        text = CleanText(text);
        int left = 0;
        int right = text.Length - 1;

        while (left < right)
        {
            if (text[left] != text[right])
                return false;

            left++;
            right--;
        }
        return true;
    }

    static void SuggestLetterForPalindrome(string text)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        text = CleanText(text);
=======
=======
>>>>>>> fce0ebdc9e3296f317b775b8b8205523028c5fea
=======
>>>>>>> fce0ebdc9e3296f317b775b8b8205523028c5fea
    
        pal = pal.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");
>>>>>>> fce0ebdc9e3296f317b775b8b8205523028c5fea

        for (int i = 0; i < text.Length; i++)
        {
            string modified = text.Remove(i, 1);
            if (IsPalindrome(modified))
            {
                Console.WriteLine($"By removing '{text[i]}', it becomes a Palindrome: \"{modified}\"");
                return;
            }
        }

        Console.WriteLine("Removing any single letter won't make it a Palindrome.");
    }

    static string CleanText(string input)
    {
        return input.ToLower()
                    .Replace(" ", "")
                    .Replace(",", "")
                    .Replace(".", "");
    }
}
