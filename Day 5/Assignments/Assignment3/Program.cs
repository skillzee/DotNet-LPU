using System;
using Assignment3;

class Program
{
    public static Candy CalculateDiscountedPrice(Candy candy)
    {
        // Total price
        candy.TotalPrice = candy.Quantity * candy.PricePerPiece;

        int discountPercentage = 0;

        if (candy.Flavour == "Strawberry")
            discountPercentage = 15;
        else if (candy.Flavour == "Lemon")
            discountPercentage = 10;
        else if (candy.Flavour == "Mint")
            discountPercentage = 5;

        // Discounted price
        candy.Discount = candy.TotalPrice -(candy.TotalPrice * discountPercentage / 100.0);

        return candy;
    }

    static void Main()
    {
        Candy candy = new Candy();

        Console.WriteLine("Enter the flavour");
        candy.Flavour = Console.ReadLine();

        Console.WriteLine("Enter the quantity");
        candy.Quantity = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the price per piece");
        candy.PricePerPiece = Convert.ToInt32(Console.ReadLine());

        if (candy.ValidateCandyFlavour())
        {
            candy = CalculateDiscountedPrice(candy);

            Console.WriteLine("Flavour : " + candy.Flavour);
            Console.WriteLine("Quantity : " + candy.Quantity);
            Console.WriteLine("Price Per Piece : " + candy.PricePerPiece);
            Console.WriteLine("Total Price : " + candy.TotalPrice);
            Console.WriteLine("Discount Price : " + candy.Discount);
        }
        else
        {
            Console.WriteLine("Invalid flavour");
        }
    }
}
