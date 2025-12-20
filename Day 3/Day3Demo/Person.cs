using System;

namespace Day3Demo;

public class Person
{
    #region Fields
    string name;
    #endregion


    public Person()
    {
        System.Console.WriteLine("Person Class Constructor Invoked");
    }


    ~Person()
    {
        System.Console.WriteLine("Person class destructor invoked");
    }


}
