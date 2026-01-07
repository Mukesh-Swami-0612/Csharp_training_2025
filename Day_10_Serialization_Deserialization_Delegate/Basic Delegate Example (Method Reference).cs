using System;

// Step 1: Declare delegate
public delegate int DelegateAddFunctionName(int a, int b);

public class MainClass
{
    // Step 2: Method matching delegate signature
    public static int AddMethod1(int a, int b)
    {
        return a + b;
    }

    // Step 3: Main method
    public static void Main(string[] args)
    {
        // Step 4: Create delegate object and assign method
        DelegateAddFunctionName addMethod =
            new DelegateAddFunctionName(AddMethod1);

        // Step 5: Call delegate
        int result = addMethod(1, 2);

        // Print result
        Console.WriteLine("Addition Result: " + result);
    }
}
