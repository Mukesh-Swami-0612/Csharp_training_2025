using System;
using System.Collections.Generic;
using System.Linq;

class HighestMarksLinq
{
    // Student class for storing student data
    class Student
    {
        public string name;
        public int rollNo;
        public int mark1;
        public int mark2;

        // Property to calculate total marks
        public int TotalMarks => mark1 + mark2;
    }

    public static void Main(string[] args)
    {
        // Creating student list
        List<Student> students = new List<Student>();

        // Adding student objects into list
        students.Add(new Student { name = "Mukesh", rollNo = 11, mark1 = 6, mark2 = 9 });
        students.Add(new Student { name = "Kumar",  rollNo = 5,  mark1 = 5, mark2 = 8 });
        students.Add(new Student { name = "Swami",  rollNo = 2,  mark1 = 7, mark2 = 9 });

        // LINQ: Sort by TotalMarks descending and take the first student
        var high = students
            .OrderByDescending(s => s.TotalMarks)
            .FirstOrDefault();

        // If student is found, print details
        if (high != null)
        {
            Console.WriteLine("Highest Marks Student Details:\n");
            Console.WriteLine($"Roll No : {high.rollNo}");
            Console.WriteLine($"Name    : {high.name}");
            Console.WriteLine($"Mark1   : {high.mark1}");
            Console.WriteLine($"Mark2   : {high.mark2}");
            Console.WriteLine($"Total   : {high.TotalMarks}");
        }
    }
}
