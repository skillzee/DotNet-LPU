// See https://aka.ms/new-console-template for more information
using Collections;

Console.WriteLine("*********Bakery Shop*************");

Console.WriteLine("Enter the number of orders: ");

int num = Int32.Parse(Console.ReadLine());

CakeOrder cakeOrder = new CakeOrder();

for(int i = 0; i < num; i++)
{
    string details = Console.ReadLine();
    string[] splitter = details.Split(':');

    string orderID = splitter[0];
    double price = Double.Parse(splitter[1]);
    //Console.WriteLine(orderID);
    //Console.WriteLine(price);
    cakeOrder.AddOrderDetails(orderID, price);


}


Console.WriteLine("Enter the cost to search the cake order: ");
double cost = Double.Parse(Console.ReadLine());

Dictionary<string, double> response = cakeOrder.findOrdersAboveSpecifiedCost(cost);

Console.WriteLine("Cake Orders above the specified cost: ");

foreach (var item in response)
{
    Console.WriteLine($"Order ID: {item.Key}, Cake Cost: {item.Value}");
}


