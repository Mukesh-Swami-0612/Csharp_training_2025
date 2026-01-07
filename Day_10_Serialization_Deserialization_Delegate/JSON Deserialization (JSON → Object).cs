using System;
using System.Text.Json;

// Person class
public class Person
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    public int Age { get; set; }
}

class Program
{
    static void Main()
    {
        // JSON string
        string json = "{\"Id\":1,\"Name\":\"Mukesh\",\"Age\":22}";

        // Convert JSON to Person object
        Person p = JsonSerializer.Deserialize<Person>(json);

        // Print object values
        Console.WriteLine("Deserialized Object:");
        Console.WriteLine("Id: " + p.Id);
        Console.WriteLine("Name: " + p.Name);
        Console.WriteLine("Age: " + p.Age);
    }
}
