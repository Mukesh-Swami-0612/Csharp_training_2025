using System;

// Delegate declaration
delegate int Operation(int a, int b);

// Calculator class
class Calculator
{
    // Add method
    public int Add(int a, int b)
    {
        return a + b;
    }

    // Multiply method
    public int Multiply(int a, int b)
    {
        return a * b;
    }
}

class Program
{
    // Method that uses delegate
    static void Process(int a, int b, Operation op)
    {
        // Call delegate
        int result = op(a, b);

        // Print result
        Console.WriteLine("Result: " + result);
    }

    static void Main(string[] args)
    {
        // Create Calculator object
        Calculator calc = new Calculator();

        // Assign instance methods to delegate
        Operation addOp = calc.Add;
        Operation mulOp = calc.Multiply;

        // Call methods via delegate
        Process(10, 5, addOp);
        Process(10, 5, mulOp);

        Console.ReadLine();
    }
}
