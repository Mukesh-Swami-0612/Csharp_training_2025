using System;

public class User
{
    public string Name { get; set; }
    public string Password { get; set; }
    public string ConfirmationPassword { get; set; }
}

public class PasswordMismatchException : Exception
{
    public PasswordMismatchException() : base("Password entered does not match")
    {
    }
}

public class Program
{
    public static User ValidatePassword(string name, string password, string confirmationPassword)
    {
        if (password != confirmationPassword)
        {
            throw new PasswordMismatchException();
        }

        return new User
        {
            Name = name,
            Password = password,
            ConfirmationPassword = confirmationPassword
        };
    }

    public static void Main(string[] args)
    {
        string name = Console.ReadLine();
        string password = Console.ReadLine();
        string confirmationPassword = Console.ReadLine();

        try
        {
            User user = ValidatePassword(name, password, confirmationPassword);
            Console.WriteLine("Registered Successfully");
        }
        catch (PasswordMismatchException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
