using System;

// Custom exception for robot safety errors
public class RobotSafetyException : Exception
{
    public RobotSafetyException(string message) : base(message)
    {
    }
}

// Class to calculate robot hazard risk
public class RobotHazardAuditor
{
    public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
    {
        // Check arm precision range
        if (armPrecision < 0.0 || armPrecision > 1.0)
        {
            throw new RobotSafetyException("Error: Arm precision must be 0.0-1.0");
        }

        // Check worker density range
        if (workerDensity < 1 || workerDensity > 20)
        {
            throw new RobotSafetyException("Error: Worker density must be 1-20");
        }

        // Store machine risk factor
        double machineRiskFactor = 0.0;

        // Set risk factor based on machine state
        if (machineryState == "Worn")
        {
            machineRiskFactor = 1.3;
        }
        else if (machineryState == "Faulty")
        {
            machineRiskFactor = 2.0;
        }
        else if (machineryState == "Critical")
        {
            machineRiskFactor = 3.0;
        }
        else
        {
            throw new RobotSafetyException("Error: Unsupported machinery state");
        }

        // Calculate final hazard risk
        double hazardRisk =
            ((1.0 - armPrecision) * 15.0) +
            (workerDensity * machineRiskFactor);

        return hazardRisk;
    }
}

// Main class
public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            // Create auditor object
            RobotHazardAuditor auditor = new RobotHazardAuditor();

            // Read user input
            Console.WriteLine("Enter Arm Precision (0.0 - 1.0):");
            double armPrecision = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Worker Density (1 - 20):");
            int workerDensity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Machinery State (Worn/Faulty/Critical):");
            string machineryState = Console.ReadLine();

            // Calculate risk
            double risk = auditor.CalculateHazardRisk(
                armPrecision,
                workerDensity,
                machineryState
            );

            // Print result
            Console.WriteLine("Robot Hazard Risk Score: " + risk);
        }
        catch (RobotSafetyException ex)
        {
            // Handle safety errors
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            // Handle other errors
            Console.WriteLine("Unexpected Error: " + ex.Message);
        }
    }
}
