using System;

namespace ConditionalAssignments;

public class Quadratic
{
    public static void QuadMain()
    {
        Console.WriteLine("The given Equation is ax^2 + bx + c");
        System.Console.Write("Write the value of a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Write the value of b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Write the value of c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        double d = b* b - 4 * a * c;
        if (d>0)
        {
            System.Console.WriteLine("Roots are real and different");
        }
        else if(d==0)
        {
            System.Console.WriteLine("Roots are real and same");
        }
        else
        {
            System.Console.WriteLine("Roots are complex and different");
        }
    }
}
