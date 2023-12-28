using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.Write("Enter the input string: ");
        string inputString = Console.ReadLine();

        Console.Write("Enter the queries (comma-separated): ");
        string[] queriesInput = Console.ReadLine().Split(',');
        int[] queries = Array.ConvertAll(queriesInput, int.Parse);

        List<string> result = WeightedStrings(inputString, queries);

        Console.WriteLine("Result: " + string.Join(", ", result));
    }

    static List<string> WeightedStrings(string inputString, int[] queries)
    {
        List<string> result = new List<string>();
        Dictionary<string, int> substringWeights = new Dictionary<string, int>();
        substringWeights.Add("c", 3);
        substringWeights.Add("cc", 6);
        for (int i = 0; i < inputString.Length; i++)
        {
            char currentChar = inputString[i];
            int weight = (currentChar - 'a' + 1);
            string substring = currentChar.ToString();

            while (i + 1 < inputString.Length && inputString[i + 1] == currentChar)
            {
                i++;
                substring += currentChar;
                weight += (currentChar - 'a' + 1);
            }

            if (!substringWeights.ContainsKey(substring))
                substringWeights.Add(substring, weight);
        }

        foreach (int query in queries)
        {
            if (substringWeights.ContainsValue(query))
                result.Add("Yes");
            else
                result.Add("No");
        }

        return result;
    }
}
