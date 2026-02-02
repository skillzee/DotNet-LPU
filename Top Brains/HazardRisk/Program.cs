using System;
namespace FactoryRobotHazardAnalyzer
{
    public class Program
    {
        public double CalculateHazardRisk(double armPrecision, int workerDensity, string machineryState)
        {
            if (armPrecision <= 0.0 || armPrecision >= 1.0)
            {
                throw new RobotSafetyException("Arm precision must be 0.0-1.0");
            }
            if (workerDensity <= 1 || workerDensity >= 20)
            {
                throw new RobotSafetyException("Worker density must be 1-20");
            }
            if (machineryState != "Worn" && machineryState != "Faulty" && machineryState != "Critical")
            {
                throw new RobotSafetyException("Unsupported machinery state");
            }
            double machineRiskFactor = 0.0;
            if (machineryState == "Worn") machineRiskFactor = 1.3;
            else if (machineryState == "Faculty") machineRiskFactor = 2.0;
            else if (machineryState == "Critical") machineRiskFactor = 3.0;

            return ((1.0 - armPrecision) * 15.0) + (workerDensity * machineRiskFactor);
        }
        public static void Main(string[] args)
        {
            
            Program p = new Program();
            try
            {
                Console.WriteLine("Enter the value of arm Precision: ");
                double armPrecision = double.Parse(Console.ReadLine());

                Console.WriteLine("Enter the value of workerDensity: ");
                int workerDensity = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter the value of machineryState: ");
                string machineryState = Console.ReadLine();
                System.Console.WriteLine(p.CalculateHazardRisk(armPrecision, workerDensity, machineryState));
            }
            catch(RobotSafetyException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
    public class RobotSafetyException : Exception
    {
        public RobotSafetyException() { }
        public RobotSafetyException(string message) : base(message) { }
    }
}
