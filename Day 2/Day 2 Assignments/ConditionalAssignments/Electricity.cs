using System;

namespace ConditionalAssignments;

public class Electricity
{

    public static void ElectricityMain()
    {
        // Calculate bill: First 199 units @ 1.20; 200-400 @ 1.50; 400-600 @ 1.80; above 600 @ 2.00. Add 15% surcharge if bill > 400.
        Console.WriteLine("Enter the number of units consumed: ");
        int units = Convert.ToInt32(Console.ReadLine());
        double bill = 0;
        if (units <= 199)
        {
            bill = units * 1.20;
        }
        else if (units >= 200 && units < 400)
        {
            bill = units * 1.50;
        }
        else if (units >= 400 && units < 600)
        {
            bill = units * 1.80;
        }
        else
        {
            bill = units * 2.00;
        }
        if (bill > 400)
        {
            bill = bill + (bill * 0.15);
        }
        Console.WriteLine("The total electricity bill is: " + bill);
    }

}
