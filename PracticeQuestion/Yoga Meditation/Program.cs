using System;
using System.Collections;

public class MeditationCenter{
    public int MemberId { get; set; }
    public int Age { get; set; }
    public double Height { get; set; }
    public double Weight { get; set; }
    public string Goal { get; set; }
    public double BMI { get; set; }

    public MeditationCenter(int memberId, int age, double height, double weight, string goal){
        MemberId = memberId;
        Age = age;
        Height = height;
        Weight = weight;
        Goal = goal;
    }
}

public class Program{
    public static ArrayList memberList = new ArrayList();

    public void AddYogaMember(int memberId, int age, double weight, double height, string goal){
        MeditationCenter m = new MeditationCenter(memberId, age, height, weight, goal);
        memberList.Add(m);
    }

    public double CalculateBMI(int memberId){
        foreach (MeditationCenter m in memberList){
            if (m.MemberId == memberId){
                double bmi = m.Weight / (m.Height * m.Height);
                bmi = Math.Floor(bmi * 100) / 100;
                m.BMI = bmi;
                return bmi;
            }
        }
        return 0;
    }

    public int CalculateYogaFee(int memberId){
        foreach (MeditationCenter m in memberList){
            if (m.MemberId == memberId){
                double bmi = m.BMI;
                if (bmi == 0){
                    bmi = CalculateBMI(memberId);
                }

                if (m.Goal.Equals("Weight Loss", StringComparison.OrdinalIgnoreCase)){
                    if (bmi >= 25 && bmi < 30)
                        return 2000;
                    else if (bmi >= 30 && bmi < 35)
                        return 2500;
                }
                else if (m.Goal.Equals("Weight Gain", StringComparison.OrdinalIgnoreCase)){
                    if (bmi < 35)
                        return 500;
                }
                return 0;
            }
        }
        return 0;
    }

    public static void Main(string[] args){
        Program p = new Program();
        Console.WriteLine("Enter number of yoga members:");
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++){
            Console.WriteLine("Enter MemberId:");
            int memberId = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Age:");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Weight:");
            double weight = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Height:");
            double height = double.Parse(Console.ReadLine());

            Console.WriteLine("Enter Goal:");
            string goal = Console.ReadLine();

            p.AddYogaMember(memberId, age, weight, height, goal);
        }

        Console.WriteLine("Enter MemberId to calculate BMI and Fee:");
        int searchId = int.Parse(Console.ReadLine());

        double bmiValue = p.CalculateBMI(searchId);

        if (bmiValue == 0){
            Console.WriteLine($"memberId '{searchId}' is not present");
        }
        else{
            Console.WriteLine("BMI: " + bmiValue.ToString("0.00"));
            int fee = p.CalculateYogaFee(searchId);
            Console.WriteLine("Yoga Fee: " + fee);
        }
    }
}
