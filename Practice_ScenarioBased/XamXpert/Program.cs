using System;
interface IExam{
    double CalculateScore();
}
class OnlineTest : IExam{
    public string StudentName;
    public string QuestionType;
    public int TotalQuestions;
    public int CorrectAnswers;
    public int WrongAnswers;

    public OnlineTest(string name, string type, int total, int correct, int wrong){
        StudentName = name;
        QuestionType = type;
        TotalQuestions = total;
        CorrectAnswers = correct;
        WrongAnswers = wrong;
    }

    public double CalculateScore(){
        int marksPerQuestion = QuestionType == "MCQ" ? 2 : 5;

        double totalScore =
            (CorrectAnswers * marksPerQuestion) -
            (WrongAnswers * (marksPerQuestion * 0.10));

        double percentage =
            (totalScore / (TotalQuestions * marksPerQuestion)) * 100;

        //return Math.Round(percentage, 1);
        return percentage;
    }

    // Evaluate result
    public static string EvaluateResult(double percentage)
    {
        if (percentage >= 85)
            return "Merit";
        else if (percentage >= 60)
            return "Pass";
        else
            return "Fail";
    }
}

// Main class
class Program
{
    static void Main()
    {
        Console.WriteLine("Enter Exam Details:");

        Console.Write("Student Name: ");
        string name = Console.ReadLine();

        Console.Write("Question Type (MCQ/Coding): ");
        string type = Console.ReadLine();

        Console.Write("Total Questions: ");
        int total = int.Parse(Console.ReadLine());

        Console.Write("Correct Answers: ");
        int correct = int.Parse(Console.ReadLine());

        int wrong = total - correct;
        Console.Write("Wrong Answers: " + wrong);
        
        //int wrong = int.Parse(Console.ReadLine());

        OnlineTest test = new OnlineTest(name, type, total, correct, wrong);

        double score = test.CalculateScore();
        string result = OnlineTest.EvaluateResult(score);

        Console.WriteLine("\nExam Summary:");
        Console.WriteLine(type + " Test: " + name + ", Total Score: " + score + ", Result: " + result);
    }
}
