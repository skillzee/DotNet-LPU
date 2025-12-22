using System;

namespace Assessment1;

public class Employee
{
    int age;
    int depChoice;

    public int EmpID{get; set;}

    public string Name {get; set;}
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value >= 21)
            {
                age = value;
            }
            else
            {
                throw new Exception("The Age is below 21");
            }
        }
    }
    public int DepChoice
    {
        get
        {
            return depChoice;
        }
        set
        {
            if(value == 1 || value == 2 || value == 3)
            {
                depChoice = value;

            }
            else
            {
                throw new Exception("The value should be 1 or 2 or 3 Nothing else");
            }
        }
    }
    public double BasSal{get; set;}


    





}
