using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexibleinventory
{
    public class GroceryProduct : Product
    {
        // TODO: Add these properties
        // - ExpiryDate (DateTime)
        // - IsPerishable (bool)
        // - Weight (double)
        // - StorageTemperature (string) - e.g., "Room temperature", "Refrigerated", "Frozen"
        public DateTime ExpiryDate { get; set; }
        public bool IsPerishable { get; set; }
        public double Weight { get; set; }
        public string StorageTemperature { get; set; }

        /// <summary>
        /// TODO: Override GetProductDetails for grocery items
        /// Include expiry information
        /// </summary>
        public override string GetProductDetails()
        {
            // TODO: Implement
            return $"Name -> {ProductName}, IsPerishable -> {IsPerishable}, Weight -> {Weight}, ExpiryDate -> {ExpiryDate.ToString()}";
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Check if product is expired
        /// </summary>
        public bool IsExpired()
        {
            // TODO: Compare ExpiryDate with current date
            if(DateTime.Now >= ExpiryDate ) return true ;

            return false ;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Calculate days until expiry
        /// Return negative if expired
        /// </summary>
        public int DaysUntilExpiry()
        {
            // TODO: Calculate days difference
            TimeSpan time = ExpiryDate - DateTime.Now;
            return (time.Days);
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Override CalculateValue to apply discount for near-expiry items
        /// Apply 20% discount if within 3 days of expiry
        /// </summary>
        public override decimal CalculateValue()
        {
            // TODO: Apply discount logic if near expiry
            TimeSpan time = ExpiryDate - DateTime.Now;
            if (time.Days <= 3)
            {
                return ProductPrice*(decimal)(0.8);
            }
            return ProductPrice;
            //throw new NotImplementedException();
        }
    }

}
