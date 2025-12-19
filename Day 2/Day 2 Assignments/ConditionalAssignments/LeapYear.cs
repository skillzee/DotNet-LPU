using System;

namespace ConditionalAssignments;

public class LeapYear
{
    public static void LeapMain()
    {
        int year = Convert.ToInt32(Console.ReadLine());
        if((year % 400 == 0) || (year%4 ==0 && year != 100))
        {
            Console.WriteLine("This is a Leap Year");
        }
        else
        {
            Console.WriteLine("This is not a Leap Year");
        }
    }
}
