using System;
using System.Text.Json;

// Person class with fields
class Person
{
    public int id;        // Public field
    public string Name = ""; // Public field
    public int Age;       // Public field
}

class Program
{
    public static void Main(string[] args)
    {
        // Create object
        Person p = new Person()
        {
            id = 1,
            Name = "Mukesh",
            Age = 22
        };

        // Serialize object to JSON
        string json = JsonSerializer.Serialize(p);

        // Print JSON
        Console.WriteLine(json);
    }
}
