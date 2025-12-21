using System;

namespace SMSApp;

public class StudentBL
{

    Student sObj = null;
    public StudentBL()
    {
        sObj = new Student();
    }
    
    public void AcceptSudentDetails()
    {
        try
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
    
            System.Console.WriteLine("Student Management System  ");
            System.Console.WriteLine("==========================");
    
    
            Console.ForegroundColor = ConsoleColor.Cyan;
            System.Console.WriteLine("Enter Roll No : ");
            sObj.RollNo = Int32.Parse(System.Console.ReadLine());
    
            System.Console.WriteLine("Enter Name : ");
            sObj.Name = System.Console.ReadLine();
    
            System.Console.WriteLine("Enter Address : ");
            sObj.Address = System.Console.ReadLine();
    
    
            System.Console.WriteLine("Enter Physics Marks : ");
            sObj.Phy = Int32.Parse(System.Console.ReadLine());
    
            System.Console.WriteLine("Enter Chemistry Marks : ");
            sObj.Chem = Int32.Parse(System.Console.ReadLine());
    
            System.Console.WriteLine("Enter Maths Marks : ");
            sObj.Math = Int32.Parse(System.Console.ReadLine());
    
        }
        catch (InvalidMarksException e)

        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(e.Message);
        }

        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            System.Console.WriteLine(e.Message);
        }

        Console.ForegroundColor = ConsoleColor.White;

    }



    public int CalcTotal()
    {
        sObj.Total = sObj.Phy + sObj.Chem + sObj.Math;
        return sObj.Total;
    }

    public float CalAvg()
    {
        sObj.Percent = sObj.Total / 300.0f * 100;
        return sObj.Percent;
    }


    public void calcResult(out int myTotal, out float perc)
    {
        myTotal = sObj.Phy + sObj.Chem + sObj.Math;
        perc = myTotal / 300.0f * 100;
    }

}
