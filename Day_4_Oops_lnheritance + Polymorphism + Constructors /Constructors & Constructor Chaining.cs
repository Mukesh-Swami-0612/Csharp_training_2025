// Problem: Demonstrate constructor chaining

using System;

public class Visitor
{
    public int Id;
    public string Name;
    public string Log = "";

    public Visitor()
    {
        Log += "Default constructor called\n";
    }

    public Visitor(int id) : this()
    {
        Id = id;
        Log += "Id constructor called\n";
    }

    public Visitor(int id, string name) : this(id)
    {
        Name = name;
        Log += "Name constructor called\n";
    }
}

class Program
{
    public static void Main()
    {
        Visitor v = new Visitor(1, "Mukesh");
        Console.WriteLine(v.Log);
    }
}
