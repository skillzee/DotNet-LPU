using System;

namespace ConditionalAssignments;

public class Triangle
{

    public static void TriangleMain()
    {
        System.Console.Write("Enter the size of side a: ");
        int a = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter the size of side b: ");
        int b = Convert.ToInt32(Console.ReadLine());
        System.Console.Write("Enter the size of side c: ");
        int c = Convert.ToInt32(Console.ReadLine());

        if (a==b && b== c)
        {
            System.Console.WriteLine("The triangle is Equilateral.");
        }
        else if (a == b || b == c || a == c)
        {
            System.Console.WriteLine("The triangle is Isosceles.");
        }
        else
        {
            System.Console.WriteLine("The triangle is Scalene.");
        }

    }

}
