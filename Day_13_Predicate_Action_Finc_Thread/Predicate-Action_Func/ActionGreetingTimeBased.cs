using System;

class ActionGreetingTimeBased
{
    public static void Main(string[] args)
    {
        // Default logger
        Action<string> logger = NewLogger();

        // If time is before 12 PM -> Good Morning
        if (DateTime.Now.Hour < 12)
        {
            logger = GoodMorning();
        }
        else
        {
            // Otherwise -> Good Day
            logger = GoodDay();
        }

        // Calling the selected Action
        logger("Mukesh");

        Console.WriteLine("\n--------------------------------\n");

        // Calling another Action method
        logger = Method2();
        logger("Application Started");
    }

    // Logger method
    private static Action<string> NewLogger()
    {
        return message =>
        {
            Console.WriteLine($"[LOG]: {message} at {DateTime.Now}");
        };
    }

    // Greeting method for morning
    private static Action<string> GoodMorning()
    {
        return message =>
        {
            Console.WriteLine($"Good Morning {message} ☀️");
        };
    }

    // Greeting method for day
    private static Action<string> GoodDay()
    {
        return message =>
        {
            Console.WriteLine($"Good Day {message} 🌞");
        };
    }

    // Another Action example
    private static Action<string> Method2()
    {
        return message =>
        {
            Console.WriteLine("Welcome to Programming 👨‍💻");
        };
    }
}
