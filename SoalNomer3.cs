using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Input: ");
        string input = Console.ReadLine();

        string result = IsBalanced(input) ? "YES" : "NO";

        Console.WriteLine("Output: " + result);
    }

    static bool IsBalanced(string input)
    {
        Stack<char> stack = new Stack<char>();

        foreach (char bracket in input)
        {
            if (IsOpeningBracket(bracket))
            {
                stack.Push(bracket);
            }
            else if (IsClosingBracket(bracket))
            {
                if (stack.Count == 0 || !IsMatchingBracket(stack.Pop(), bracket))
                {
                    return false;
                }
            }
        }

        return stack.Count == 0;
    }

    static bool IsOpeningBracket(char bracket)
    {
        return bracket == '(' || bracket == '{' || bracket == '[';
    }

    static bool IsClosingBracket(char bracket)
    {
        return bracket == ')' || bracket == '}' || bracket == ']';
    }

    static bool IsMatchingBracket(char openBracket, char closeBracket)
    {
        return (openBracket == '(' && closeBracket == ')') ||
               (openBracket == '{' && closeBracket == '}') ||
               (openBracket == '[' && closeBracket == ']');
    }
}

