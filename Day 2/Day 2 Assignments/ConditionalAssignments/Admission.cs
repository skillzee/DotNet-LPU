using System;

namespace ConditionalAssignments;

public class Admission
{

    public static void AdmissionMain()
    {
        Console.WriteLine("Enter the marks of Physics: ");
        int physics = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks of Chemistry: ");
        int chemistry = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the marks of Mathematics: ");
        int mathematics = Convert.ToInt32(Console.ReadLine());

        int total = physics + chemistry + mathematics;

        if (mathematics >= 65 && physics >= 55 && chemistry >= 50 && (total >= 180 || (mathematics + physics) >= 140))
        {
            Console.WriteLine("The candidate is eligible for admission.");
        }
        else
        {
            Console.WriteLine("The candidate is not eligible for admission.");
        }
    }


}
