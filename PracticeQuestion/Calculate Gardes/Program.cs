using System;
using System.Collections.Generic;

public class Program
{
    public static List<int> NumberList = new List<int>();

    public void AddNumbers(int numbers)
    {
        NumberList.Add(numbers);
    }

    public double GPAScored()
    {
        if (NumberList.Count == 0)
            return -1;

        double sum = 0;

        foreach (int n in NumberList)
        {
            sum += n * 3;
        }

        double gpa = sum / (NumberList.Count * 3);
        return gpa;
    }

    public char GradeScored(double gpa)
    {
        if (gpa < 5 || gpa > 10)
            return '\0';

        if (gpa == 10)
            return 'S';
        else if (gpa >= 9 && gpa < 10)
            return 'A';
        else if (gpa >= 8 && gpa < 9)
            return 'B';
        else if (gpa >= 7 && gpa < 8)
            return 'C';
        else if (gpa >= 6 && gpa < 7)
            return 'D';
        else
            return 'E';
    }

    public static void Main(string[] args)
    {
        Program p = new Program();

        Console.WriteLine("Enter number of subjects:");
        int n = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the scores:");
        for (int i = 0; i < n; i++)
        {
            int score = int.Parse(Console.ReadLine());
            p.AddNumbers(score);
        }

        double gpa = p.GPAScored();

        if (gpa == -1)
        {
            Console.WriteLine("No Numbers available");
            return;
        }

        Console.WriteLine("GPA Score: " + gpa.ToString("0.00"));

        char grade = p.GradeScored(gpa);

        if (grade == '\0')
        {
            Console.WriteLine("Invalid GPA");
        }
        else
        {
            Console.WriteLine("Grade: " + grade);
        }
    }
}
