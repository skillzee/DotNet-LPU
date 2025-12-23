using System;

namespace Assignment2;

public class Cake
{

    public string? Flavour{get; set;}
    public int Quantity{get; set;}
    public double Price{get; set;}


    public bool CakeOrder()
    {
        if(Quantity > 0)
        {
            if(Flavour == "Chocolate" || Flavour == "Red Velvet" || Flavour == "Vanilla")
            {
                return true;
            }
            else
            {
                throw new InvalidFlavourException("Flavour not available. Please select the available flavour");
            }
        }
        else
        {
            throw new InvalidFlavourException("Quantity Must be graeter than 0");
        }

        
        
    }




    public double CalculatePrice()
    {
        double totalPrice = Quantity*Price;
        int discount = 0;
        if(Flavour == "Vanilla") discount = 3;
        if(Flavour == "Chocolate") discount = 5;
        if(Flavour == "Red Velvet") discount = 10;
        double discountedPrice = totalPrice - (totalPrice * discount/100);

        return discountedPrice;
    }

}
