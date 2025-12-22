using System;

namespace Day4OOPDemo;

public class Clerk:Employee
{   

    public int ClrkID { get; set; }
    public int Bonus { get; set; }

    public override int CalculateSalary(int sal)
    {
        return 0;
    }

}
