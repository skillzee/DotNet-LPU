using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logisctic_Question_1
{
    public class ShipmentDetails:Shipment
    {

        

        public bool ValidateShipmentCode()
        {
            if (ShipmentCode.Length < 7)
            {
                return false; 
            }

            if(ShipmentCode.Substring(0, 3) != "GC#")
            {
                return false; 
            }
            string restDigits = ShipmentCode.Substring(3);
            foreach(var item in restDigits)
            {
                if(!Char.IsDigit(item))
                {
                    return false; 
                }
            }

            return true;
        }

        public double CalculateTotalCost()
        {

            double totalCost = 0;
             
          
                string transferMode = TransportMode;

                double ratePerKg = 0;

                if(transferMode == "Sea")
                {
                    ratePerKg = 15.00;
                }else if(transferMode == "Air")
                {
                    ratePerKg = 50.00;
                }
                else
                {
                    ratePerKg = 25.00;
                }

                totalCost += (Weight * ratePerKg) + Math.Sqrt(StorageDays);



            return Math.Round(totalCost, 2);
        }
    }
}
