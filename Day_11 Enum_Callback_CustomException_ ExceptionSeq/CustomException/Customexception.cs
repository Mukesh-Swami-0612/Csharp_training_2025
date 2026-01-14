using System;

namespace LearningCSharp
{
    // This is our custom exception class
    // It inherits from the built-in Exception class
    public class AppCustomException : Exception
    {
        // We are overriding the Message property
        // So whenever someone prints ex.Message, this custom message will come
        public override string Message => HandleBase(base.Message);

        // This method handles the original system error message
        private string HandleBase(string sysMessage)
        {
            // Print the original exception message (system generated)
            Console.WriteLine(sysMessage);

            // Return a user-friendly message instead of system message
            return "Internal Exception occured, Please contact admin";
        }
    }

    // Main class where program runs
    public class CustomException
    {
        // Main method (program starts from here)
        public static void Main()
        {
            try
            {
                // Trying to divide 10 by 0 (this will cause an error)
                int result = Divide(10, 0);

                // This line will not run because exception happens above
                Console.WriteLine("Result: " + result);
            }
            catch (AppCustomException ex)
            {
                // Catching the custom exception
                // Printing the custom error message
                Console.WriteLine("Error: " + ex.Message);
            }
        }

        // This method is used to divide two numbers
        private static int Divide(int v1, int v2)
        {
            try
            {
                // Performing division
                return v1 / v2;
            }
            catch
            {
                // If division fails, throw our custom exception
                throw new AppCustomException();
            }
        }
    }
}
