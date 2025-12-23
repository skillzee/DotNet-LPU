using System;

namespace Assignment2;

public class Cake
{

    public string? Flavour{get; set;}
    public int Quantity{get; set;}
    public double Price{get; set;}


    public bool CakeOrder()
    {
        if(Flavour == "Chocolate" || Flavour == "Red Velvet" || Flavour == "Vanilla")
        {
            return true;
        }
        else
        {
            throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
        }

        ;
        
    }

}
