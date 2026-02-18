using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexibleinventory
{
    /// <summary>
    /// TODO: Implement abstract base class for all products
    /// </summary>
    public abstract class Product
    {
        // TODO: Add these properties
        // - Id (string)
        // - Name (string)
        // - Price (decimal)
        // - Quantity (int)
        // - Category (string)
        // - DateAdded (DateTime)
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int Quantity { get; set; }
        public string Category { get; set; }
        public DateTime DateAdded { get; set; }

        /// <summary>
        /// TODO: Implement abstract method to get product-specific details
        /// </summary>
        public abstract string GetProductDetails();

        /// <summary>
        /// TODO: Implement virtual method to calculate inventory value
        /// Default: Price * Quantity
        /// </summary>
        public virtual decimal CalculateValue()
        {
            // TODO: Return Price * Quantity
            return ProductPrice * Quantity;
            
        }

        /// <summary>
        /// TODO: Override ToString() to return product summary
        /// </summary>
        public override string ToString()
        {
            // TODO: Return formatted string with Id, Name, Price, Quantity
            return $"Id -> {ProductId}, Name-> {ProductName}, Price ->{ProductPrice}, Quantity -> {Quantity}";
        }
    }

}
