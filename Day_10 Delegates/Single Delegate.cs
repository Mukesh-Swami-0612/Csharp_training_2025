using System;

// Step 1: Create a delegate (It works like a function pointer)
// It can store and call a method that takes (string) and returns (void)
delegate void PrintMessage(string message);

class Program
{
    // Step 2: Create a method that matches delegate signature
    static void ShowMessage(string msg)
    {
        Console.WriteLine(msg);
    }

    static void Main()
    {
        // Step 3: Assign method to delegate variable
        PrintMessage print = ShowMessage;

        // Step 4: Call delegate like a function
        print("Hello Delegate");
    }
}
