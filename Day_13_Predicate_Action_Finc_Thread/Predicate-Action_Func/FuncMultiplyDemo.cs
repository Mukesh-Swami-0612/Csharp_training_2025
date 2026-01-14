using System;

class FuncMultiplyDemo
{
    public static void Main(string[] args)
    {
        // Func<int, int, string> means:
        // Takes 2 int inputs (x, y)
        // Returns string output
        Func<int, int, string> multiplyResult = (x, y) =>
        {
            // Returning formatted string with multiplication result
            return $"{x} times {y} is {x * y}";
        };

        // Calling the Func delegate
        string resultText = multiplyResult(5, 4);

        // Print output
        Console.WriteLine(resultText);
    }
}
