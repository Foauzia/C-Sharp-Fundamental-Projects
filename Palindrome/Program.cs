using System;
using System.Text.RegularExpressions;
class Program
{
    static void Main()
    {

        Console.WriteLine("Enter a number or string you wanted to check? ");
        string palindrome = Console.ReadLine();


        if (IsPalindrome(palindrome))
        {
            Console.WriteLine($"{palindrome} is a Palindrome.");
        }
        else
        {
            Console.WriteLine($"{palindrome} is not a Palindrome.");
            SuggestLetterForPalindrome(palindrome);
        }
    }

    static bool IsPalindrome(string pal)
    {

        pal = pal.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");

        int left = 0;
        int right = pal.Length - 1;

        while (left < right)
        {
            if (pal[left] != pal[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    static void SuggestLetterForPalindrome(string pal)
    {
    
        pal = pal.ToLower().Replace(" ", "").Replace(",", "").Replace(".", "");

        for (int p = 0; p < pal.Length; p++)
        {
            string modified = pal.Remove(p, 1);
            if (IsPalindrome(modified))
            {
                Console.WriteLine($"Removal of a letter '{pal[p]}', the word becomes a Palindrome.");
                return;
            }
        }

        Console.WriteLine("Any removal of string or number wouldn't make it Palindrome.");
    }
}
