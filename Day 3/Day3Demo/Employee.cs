using System;

namespace Day3Demo;

public class Employee: Person
{

    string skill;
    string desig;
    int empId;
    int bSal;

    public Employee()
    {
        System.Console.WriteLine("Employee Class Constructor Invoked");
    }


    ~Employee()
    {
        System.Console.WriteLine("Employee class destructor invoked");
    }
}
