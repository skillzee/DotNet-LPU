using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPA_Calculator
{
    public class Program
    {
        // In your template this is already provided.
        public static List<int> NumberList = new List<int>();

        public void AddNumbers(int numbers)
        {
           NumberList.Add(numbers);
        }

        public double GetGPAScored()
        {
            double cubeSum = 0;
            for(int i = 0; i<NumberList.Count; i++)
            {
                cubeSum += NumberList[i] * 3;
            }

            return cubeSum/(NumberList.Count*3);
           
        }

        public char GetGradeScored(double gpa)
        {

            if (gpa == 10) return 'S';
            else if (gpa >= 9 && gpa <= 10) return 'A';
            else if (gpa >= 8 && gpa <= 9) return 'B';
            else if (gpa >= 7 && gpa < 8) return 'C';
            else if (gpa >= 6 && gpa < 7) return 'D';
            else
            {
                return 'E';
            }
           
        }

        public static void Main()
        {
            Program p = new Program();

            Console.Write("Enter how many numbers: ");
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                p.AddNumbers(int.Parse(Console.ReadLine()));
            }

            double gpa = p.GetGPAScored();
            if (gpa == -1)
            {
                Console.WriteLine("No Numbers Available");
                return;
            }

            Console.WriteLine($"GPA: {gpa}");
            char grade = p.GetGradeScored(gpa);

            if (grade == '\0')
                Console.WriteLine("Invalid GPA");
            else
                Console.WriteLine($"Grade: {grade}");
        }
    }
}
