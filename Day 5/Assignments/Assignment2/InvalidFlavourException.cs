using System;

namespace Assignment2;

public class InvalidFlavourException:Exception
{
    public InvalidFlavourException():base()
    {
        
    }
    public InvalidFlavourException(string message):base(message)
    {
        
    }
}
