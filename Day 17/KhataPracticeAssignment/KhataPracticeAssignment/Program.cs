// See https://aka.ms/new-console-template for more information
using KhataPracticeAssignment;

Console.WriteLine("Welcome to Khata Ebook");


Console.WriteLine("Press 1 to add Item and amount. \n Any other Key to exit");
int choice = Convert.ToInt32(Console.ReadLine());
Dictionary<string,int> khataInfo = new Dictionary<string,int>();

Khata khata = new Khata(khataInfo);

while(choice == 1)
{
    Console.WriteLine("Enter the name of the Item: ");
    string ?name = Console.ReadLine();
    Console.WriteLine("Enter the Price of the Item: ");
    int price = Convert.ToInt32(Console.ReadLine());
    khata.AddItem(name, price);
    Console.WriteLine("Press 1 to Add More Item. \n Any other key to exit");
    choice = Convert.ToInt32(Console.ReadLine());
}

Console.WriteLine("Total Amount: "+ khata.getTotal());
Console.WriteLine("Repeated Amount Count: "+ khata.getRepeatAmount());


