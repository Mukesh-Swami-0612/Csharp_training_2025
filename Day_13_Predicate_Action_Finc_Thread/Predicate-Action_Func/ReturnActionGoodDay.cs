using System;

class ReturnActionGoodDay
{
    public static void Main(string[] args)
    {
        // GoodDay() returns an Action<string>
        Action<string> logger = GoodDay();

        // Calling that Action
        logger("Mukesh");
    }

    // This method returns a function (Action delegate)
    public static Action<string> GoodDay()
    {
        // Returning a lambda function
        return (str) =>
        {
            Console.WriteLine("Good Day dear " + str);
        };
    }
}
