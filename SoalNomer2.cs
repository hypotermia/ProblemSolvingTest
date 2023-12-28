using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the string: ");
        string input = Console.ReadLine();

        Console.Write("Enter the value of k: ");
        int k = int.Parse(Console.ReadLine());

        string result = HighestPalindrome(input, k);

        Console.WriteLine("Output: " + result);
    }

    static string HighestPalindrome(string input, int k)
    {
        if (IsPalindrome(input))
            return input;

        if (k == 0 || input.Length == 0)
            return "-1";

        char maxChar = GetMaxChar(input);

        int maxCharIndex = input.LastIndexOf(maxChar);
        int diff = maxChar - input[maxCharIndex];

        char[] inputArray = input.ToCharArray();
        inputArray[maxCharIndex] = maxChar;
        inputArray[input.Length - maxCharIndex - 1] = maxChar;

        return HighestPalindrome(new string(inputArray), k - diff);
    }

    static bool IsPalindrome(string str)
    {
        int len = str.Length;
        for (int i = 0; i < len / 2; i++)
        {
            if (str[i] != str[len - i - 1])
                return false;
        }
        return true;
    }

    static char GetMaxChar(string str)
    {
        char maxChar = '0';
        foreach (char c in str)
        {
            if (c > maxChar)
                maxChar = c;
        }
        return maxChar;
    }
}
