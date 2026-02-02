
using System;

class Program
{
    public static string CleanseAndInvert(string input)
    {
        // Rule 1: Check for null or length < 6
        if (string.IsNullOrEmpty(input) || input.Length < 6)
        {
            return "";
        }

        // Rule 2: Check for space, digit, or special character
        foreach (char ch in input)
        {
            if (!char.IsLetter(ch))
            {
                return "";
            }
        }

        // Convert to lowercase
        input = input.ToLower();

        string filtered = "";

        // Remove characters with even ASCII values
        foreach (char ch in input)
        {
            int ascii = (int)ch;

            if (ascii % 2 != 0) // keep only odd ASCII
            {
                filtered += ch;
            }
        }

        // Reverse the string
        char[] arr = filtered.ToCharArray();
        Array.Reverse(arr);
        string reversed = new string(arr);

        // Convert even index characters to uppercase
        char[] result = reversed.ToCharArray();

        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = char.ToUpper(result[i]);
            }
        }

        return new string(result);
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the word");

        string input = Console.ReadLine();

        string output = CleanseAndInvert(input);

        if (output == "")
        {
            Console.WriteLine("Invalid Input");
        }
        else
        {
            Console.WriteLine("The generated key is - " + output);
        }
    }
}
