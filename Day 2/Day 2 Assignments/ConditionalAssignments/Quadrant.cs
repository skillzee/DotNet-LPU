using System;

namespace ConditionalAssignments;

public class Quadrant
{
    public static void QuadMain()
    {
        Console.WriteLine("Enter the value of x coordinate: ");
        int x = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value of y coordinate: ");
        int y = Convert.ToInt32(Console.ReadLine());

        if (x >0 && y> 0)
        {
            Console.WriteLine("The point lies in First Quadrant");
        }
        else if (x <0 && y > 0)
        {
            Console.WriteLine("The point lies in Second Quadrant");
        }
        else if (x < 0 && y < 0)
        {
            Console.WriteLine("The point lies in Third Quadrant");
        }
        else if (x>0 && y < 0)
        {
            Console.WriteLine("The point lies in Fourth Quadrant");
        }
        else
        {
            Console.WriteLine("The point lies on the Axis");
        }
    }
}
