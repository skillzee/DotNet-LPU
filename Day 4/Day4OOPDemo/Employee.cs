using System;

namespace Day4OOPDemo;

abstract public class Employee
{
    #region  Properties
        public int EmployeeID { get; set; }
        public string Name { get; set; }
        public int BasicSal { get; set; }
    #endregion



    // public virtual int CalculateSalary(int sal)
    // {
    //     int mySal = 0;
    //     // NetSalary = Sal+HRA+TA+DA-PF
    //     mySal = (sal+15000+3000+1500-2500);
        
    //     return mySal;
    // }

    public abstract int CalculateSalary(int sal);
}
