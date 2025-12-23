// See https://aka.ms/new-console-template for more information
using Assignment1;

Console.WriteLine("Hello, World!");


System.Console.WriteLine($"Choose the option: \n 1. Desktop \n 2. Laptop");
int choice = Convert.ToInt32(Console.ReadLine());

switch (choice)
{
    case 1: 
        Desktop desktop = new Desktop();
        System.Console.WriteLine("Enter the processor");
        desktop.Processor = Console.ReadLine();
        System.Console.WriteLine("Enter the Ram Size");
        desktop.RamSize = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Hard Disk Size");
        desktop.HardDiskSize = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Graphic Card Size");
        desktop.GraphicCard = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Monitor Size");
        desktop.MonitorSize = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Power Supply Volt: ");
        desktop.PowerSupplyVolt = Convert.ToInt32(Console.ReadLine());

        double ans = desktop.DesktopPriceCalculation();

        Console.WriteLine($"Desktop price is {ans}");


        break;
    case 2:
        Laptop laptop = new Laptop();
        System.Console.WriteLine("Enter the processor");
        laptop.Processor = Console.ReadLine();
        System.Console.WriteLine("Enter the Ram Size");
        laptop.RamSize = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Hard Disk Size");
        laptop.HardDiskSize = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Graphic Card Size");
        laptop.GraphicCard = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Display Size");
        laptop.Displaysize = Convert.ToInt32(Console.ReadLine());
        System.Console.WriteLine("Enter the Battery Volt: ");
        laptop.BatteryVolt = Convert.ToInt32(Console.ReadLine());

        double ansLaptop = laptop.LaptopPriceCalculation();
        Console.WriteLine($"Desktop price is {ansLaptop}");

        break;
}