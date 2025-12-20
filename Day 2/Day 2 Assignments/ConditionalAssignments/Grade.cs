using System;

namespace ConditionalAssignments;

public class Grade
{
    public static void GradeMain()
    {
        // Grade Description: Input grade (E, V, G, A, F) and print (Excellent, Very Good, Good, Average, Fail) using switch
        Console.WriteLine("Enter the grade (E, V, G, A, F): ");
        char grade = Convert.ToChar(Console.Read());

        switch (Char.ToUpper(grade))
        {
            case 'E':
                Console.WriteLine("Excellent");
                break;
            case 'V':
                Console.WriteLine("Very Good");
                break;
            case 'G':
                Console.WriteLine("Good");
                break;
            case 'A':
                Console.WriteLine("Average");
                break;
            case 'F':
                Console.WriteLine("Fail");
                break;
            default:
                Console.WriteLine("Invalid Grade");
                break;
        }
    }
}