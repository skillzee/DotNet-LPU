using System;

namespace ConditionalAssignments;

public class LargestOfThree
{
    public static void LargestMain()
    {
        Console.WriteLine("Enter the first digit: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Second digit: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the first digit: ");
        int c = Convert.ToInt32(Console.ReadLine());


        if (a > b)
        {
            if (a > c)
            {
                Console.WriteLine("{0} is the greatest Numbeer", a);
            }
        }
        else if (b > c)
        {
            if (b > a)
            Console.WriteLine("{0} is the greatest Number", b);
        }
        else
        {
            Console.WriteLine("{0} is the greatest Number", c);
        }
        }

    }


