// See https://aka.ms/new-console-template for more information
using Assignment2;

Console.WriteLine("Hello, World!");



try
{
    System.Console.WriteLine("Enter the Flavour: ");
    Cake cake = new Cake();
    cake.Flavour = Console.ReadLine();
    System.Console.WriteLine("Enter the Quantity in Kg: ");
    cake.Quantity = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Enter the Price: ");
    cake.Price = Convert.ToInt32(Console.ReadLine());


    if (cake.CakeOrder())
    {
        double cost = cake.CalculatePrice();
        System.Console.WriteLine($"Cake order was successful \nPrice after discount is {cost}");
    }


}
catch(InvalidFlavourException e)
{
    System.Console.WriteLine(e.Message);
}