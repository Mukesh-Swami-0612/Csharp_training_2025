using System;

// Step 1: Declare delegate
delegate int Operation(int a, int b);

class Program
{
    // Method for addition
    static int Add(int a, int b)
    {
        return a + b;
    }

    // Method for subtraction
    static int Subtract(int a, int b)
    {
        return a - b;
    }

    // Method that accepts delegate
    static void Process(int a, int b, Operation op)
    {
        // Call delegate
        int result = op(a, b);

        // Print result
        Console.WriteLine("Result: " + result);
    }

    static void Main(string[] args)
    {
        // Pass methods as delegate
        Process(10, 5, Add);
        Process(10, 5, Subtract);

        Console.ReadLine();
    }
}
