using System;





        Console.WriteLine("Enter the dimension:");
        int feet = Convert.ToInt32(Console.ReadLine());
        double cm = feet * 30.48;
        double ans = Math.Round(cm, 2, MidpointRounding.AwayFromZero);
        Console.WriteLine("Answer in centimeter: " + ans);


