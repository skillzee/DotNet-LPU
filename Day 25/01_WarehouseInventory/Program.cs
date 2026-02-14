using System;
using Services;
using Domain;
using Exceptions;

class Program
{
    static void Main()
    {
        ManagementService service = new ManagementService();

        try
        {
            var e1 = new Electronics(1, "SKU101", "Laptop", 20, 1);
            var p1 = new Perishable(2, "SKU102", "Milk", 3, 2); // Will trigger LowStockException
            var f1 = new FragileItem(3, "SKU103", "Glass Vase", 10, 5);

            service.AddEntity(e1);
            service.AddEntity(f1);
            service.AddEntity(p1); // Exception here
        }
        catch (InventoryException ex)
        {
            Console.WriteLine($"Custom Exception: {ex.Message}");
        }

        Console.WriteLine("\nAll Products:");
        foreach (var product in service.GetAll())
        {
            Console.WriteLine(product);
        }

        Console.WriteLine("\nHighest Priority Products:");
        foreach (var product in service.GetHighestPriorityProducts())
        {
            Console.WriteLine(product);
        }

        Console.ReadLine();
    }
}
