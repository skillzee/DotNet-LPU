using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeavenHomes
{
    public class Appartment
    {
        public Dictionary<String, double> apartmentDetailsMap { get; set; }

        public Appartment()
        {
            apartmentDetailsMap = new Dictionary<String, double>();
        }

        public void AddApartmentDetails(string apartmentNumber, double rent)
        {
            apartmentDetailsMap.Add(apartmentNumber, rent);
        }

        public double findTotalRentOfApartmentsInTheGivenRange(double minimumRent, double maximumRent)
        {
            double total = 0;
            foreach(var item in apartmentDetailsMap.Values)
            {
                if(item>=minimumRent && item <= maximumRent)
                {
                    total += item;
                }
            }
            return total;
        }
    }
}
