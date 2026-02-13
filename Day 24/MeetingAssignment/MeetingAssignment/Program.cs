using System;
using System.Collections.Generic;

namespace MeetingAssignment
{
    public class Program
    {
        public static Dictionary<int, Jwellery> jewelleryDetails = new Dictionary<int, Jwellery>();

        static void Main(string[] args)
        {

            jewelleryDetails.Add(1, new Jwellery { Id = "JW01", Type = "Bracelet", Material = "Silver", Price = 2000 });
            jewelleryDetails.Add(2, new Jwellery { Id = "JW02", Type = "Ring", Material = "Gold", Price = 5000 });
            jewelleryDetails.Add(3, new Jwellery { Id = "JW03", Type = "Necklace", Material = "Gold", Price = 8000 });

            JwelleryUtility utility = new JwelleryUtility();

            while (true)
            {
                Console.WriteLine("1. Get Jewellery Details");
                Console.WriteLine("2. Update Price");
                Console.WriteLine("3. Exit");
                Console.WriteLine("\nEnter your choice");

                int choice = Convert.ToInt32(Console.ReadLine());

                if (choice == 1)
                {
                    Console.WriteLine("Enter the jewellery id");
                    string id = Console.ReadLine();

                    var result = utility.GetJewelleryDetails(id);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("Jewellery id not found");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine(item.Key + "   " + item.Value);
                        }
                    }
                }
                else if (choice == 2)
                {
                    Console.WriteLine("Enter the jewellery id");
                    string id = Console.ReadLine();

                    Console.WriteLine("Enter the price to be updated");
                    int price = Convert.ToInt32(Console.ReadLine());

                    var result = utility.UpdateJewelleryPrice(id, price);

                    if (result.Count == 0)
                    {
                        Console.WriteLine("Jewellery id not found");
                    }
                    else
                    {
                        foreach (var item in result)
                        {
                            Console.WriteLine($"Id : {item.Value.Id},    Type : {item.Value.Type},    Material : {item.Value.Material},    Price : {item.Value.Price}");
                        }
                    }
                }
                else if (choice == 3)
                {
                    Console.WriteLine("Thank you");
                    break;
                }
            }
        }
    }
}
