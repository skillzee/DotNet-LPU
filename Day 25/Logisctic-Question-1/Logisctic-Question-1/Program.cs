using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logisctic_Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShipmentDetails shipment = new ShipmentDetails();
            shipment.ShipmentCode = "GC#1001";
            shipment.TransportMode = "Air";
            shipment.Weight = 10;
            shipment.StorageDays = 16;


            double cost = shipment.CalculateTotalCost();
            Console.WriteLine(cost);
        }
    }
}
