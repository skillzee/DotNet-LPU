using System;

namespace SMSApp;

public class Student
{
    int rollNo;
    int phy;
    int chem;
    int maths;
    int total;
    float percent;

    // CLR Properties (Common Language Runtime)
    public int RollNo
    {
        set
        {
            rollNo = value;
        }
        get
        {
            return rollNo;
        }
    }

    // Auto implicit property
    public string Name{get; set;}

    public string Address{get; set;}
    public int Total
    {
        get
        {
            return total;
        }
        set
        {
            total = value;
        }
    }
    public float Percent{get; set;}

    public int Phy
    {
        get
        {
            return phy;
        }
        set
        {
            if(value>=0 && value <= 100)
            {
                phy=value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }
    public int Chem
    {
        get
        {
            return chem;
        }
        set
        {
            if(value>=0 && value <= 100)
            {
                chem=value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }

    public int Math
    {
        get
        {
            return maths;
        }
        set
        {
            if(value>=0 && value <= 100)
            {
                maths=value;
            }
            else
            {
                throw new InvalidMarksException("Invalid Marks");
            }
        }
    }

}
public class InvalidMarksException : Exception
{
    public InvalidMarksException(string msg) : base(msg)
    {


    }
}
