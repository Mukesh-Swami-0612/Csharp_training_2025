using System;

class TechXam
{
    static void Main()
    {
        Console.WriteLine("Enter the username");
        string username = Console.ReadLine();
        if (username.Length != 8)
        {
            Console.WriteLine(username + " is an invalid username");
            return;
        }
        for (int i = 0; i < 4; i++)
        {
            if (!char.IsUpper(username[i]))
            {
                Console.WriteLine(username + " is an invalid username");
                return;
            }
        }
        if (username[4] != '@')
        {
            Console.WriteLine(username + " is an invalid username");
            return;
        }
        string courseIdStr = username.Substring(5, 3);
        int courseId;

        if (!int.TryParse(courseIdStr, out courseId))
        {
            Console.WriteLine(username + " is an invalid username");
            return;
        }

        if (courseId < 101 || courseId > 115)
        {
            Console.WriteLine(username + " is an invalid username");
            return;
        }

        int asciiSum = 0;
        for (int i = 0; i < 4; i++)
        {
            asciiSum += char.ToLower(username[i]);
        }

        string lastTwoDigits = courseIdStr.Substring(1, 2);

        string password = "TECH_" + asciiSum + lastTwoDigits;
        Console.WriteLine("Password: " + password);
    }
}
