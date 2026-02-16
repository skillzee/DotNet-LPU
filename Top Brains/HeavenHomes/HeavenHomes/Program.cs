using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenHomes
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of details to be added");
            int a = Int32.Parse(Console.ReadLine());
            Appartment appartment = new Appartment();
            Console.WriteLine("Enter the details");
            for(int i = 0; i<a; i++)
            {
                string input = Console.ReadLine();
                string[] inputArr = input.Split(':');
                string id = inputArr[0];
                double rent = Convert.ToDouble(inputArr[1]);
                appartment.apartmentDetailsMap.Add(id, rent);
            }

            Console.WriteLine("Enter the range to filter details");
            int min = Int32.Parse(Console.ReadLine());
            int max = Int32.Parse(Console.ReadLine());

            Console.WriteLine($"Total Rent in the Range {min} and {max} USD: {appartment.findTotalRentOfApartmentsInTheGivenRange(min, max)}");


        }
    }
}
