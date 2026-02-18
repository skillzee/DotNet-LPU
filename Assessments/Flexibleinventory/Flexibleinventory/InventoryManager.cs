using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flexibleinventory
{
    public class InventoryManager : IInventoryOperations, IReportGenerator
    {
        // TODO: Declare a private List<Product> to store products
        List<Product> products;
        // TODO: Add a thread-safety lock object (optional)

        public InventoryManager()
        {
            // TODO: Initialize the products list
            products = new List<Product>();
        }

        // ============ IInventoryOperations Implementation ============

        /// <summary>
        /// TODO: Add a product to inventory
        /// Rules:
        /// - Product cannot be null
        /// - Product ID must be unique
        /// - Price must be positive
        /// - Quantity cannot be negative
        /// </summary>
        public bool AddProduct(Product product)
        {
            // TODO: Validate product
            // TODO: Check for duplicate ID
            // TODO: Add to collection
            // TODO: Return true if successful
            if (products == null)
            {
                return false;
            }
            foreach (var item in products)
            {
                if (item.ProductId == product.ProductId)
                {
                    return false;
                }
            }
            if (product.ProductPrice < 0 || product.Quantity<0)
            {
                return false;
            }

            products.Add(product);
            return true;

            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Remove product by ID
        /// Return false if product not found
        /// </summary>
        public bool RemoveProduct(string productId)
        {
            // TODO: Find and remove product
            var product = products.FirstOrDefault(item => item.ProductId == productId);
            if(product == null)
            {
                return false;
            }
            products.Remove(product);
            return true;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Find product by ID
        /// Return null if not found
        /// </summary>
        public Product FindProduct(string productId)
        {
            // TODO: Search and return product
            var product = products.FirstOrDefault(item=>item.ProductId == productId);
            if( product == null )
            {
                return null;
            }
            return product;

            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Get all products in a specific category
        /// Use case-insensitive comparison
        /// </summary>
        public List<Product> GetProductsByCategory(string category)
        {
            // TODO: Filter products by category
            category = category.ToLower();
            var filtered = products.Where(item=> item.Category.ToLower() == category);
            return filtered.ToList();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Update product quantity
        /// Rules:
        /// - Quantity cannot be negative
        /// - Return false if product not found
        /// - Return false if new quantity is invalid
        /// </summary>
        public bool UpdateQuantity(string productId, int newQuantity)
        {
            // TODO: Validate and update quantity
            if (newQuantity < 0)
            {
                return false; 
            }
            var product = products.FirstOrDefault(item => item.ProductId == productId);
            if(product == null)
            {
                return false;
            } 
            product.Quantity= newQuantity;
            return true;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Calculate total value of all products
        /// Use CalculateValue() method of each product
        /// </summary>
        public decimal GetTotalInventoryValue()
        {
            // TODO: Sum up all product values
            decimal sum = 0;
            foreach(var item in products)
            {
                sum += item.CalculateValue();
            }
            return sum;
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Get products with quantity below threshold
        /// </summary>
        public List<Product> GetLowStockProducts(int threshold)
        {
            // TODO: Filter products with Quantity < threshold
            var filtered = products.Where(item => item.Quantity < threshold);
            return filtered.ToList();
            //throw new NotImplementedException();
        }

        // ============ IReportGenerator Implementation ============

        /// <summary>
        /// TODO: Generate complete inventory report
        /// Format:
        /// ================================
        /// INVENTORY REPORT
        /// ================================
        /// Total Products: {count}
        /// Total Value: {value:C}
        /// 
        /// Product List:
        /// {For each product: Id - Name - Category - Quantity - Value:C}
        /// </summary>
        public string GenerateInventoryReport()
        {
            // TODO: Build formatted report
            StringBuilder sb = new StringBuilder();


            sb.Append("================================\n");
            sb.Append("INVENTORY REPORT\n");
            sb.Append("================================\n");
            sb.Append($"Total Products: {products.Count}\n");
            sb.Append($"Total Value: {GetTotalInventoryValue()}\n");
            sb.Append("\n");
            sb.Append("Product List:\n");
            foreach(var item in products)
            {
                sb.Append(item.ToString());
            }


            return sb.ToString();


            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Generate category-wise summary
        /// Format:
        /// CATEGORY SUMMARY
        /// {Category1}: {count} items - Total Value: {value:C}
        /// {Category2}: {count} items - Total Value: {value:C}
        /// </summary>
        public string GenerateCategorySummary()
        {
            // TODO: Group by category and summarize
            StringBuilder sb = new StringBuilder();
            var grouping = products.GroupBy(item => item.Category);
            sb.Append("CATEGORY SUMMARY\n");
            foreach (var item in grouping)
            {
                string categoryName = item.Key;
                int count = item.Count();
                decimal totalValue = item.Sum(x => x.CalculateValue());
                sb.Append($"{categoryName} : {count} items - Total Value: {totalValue} \n");
            }

            return sb.ToString();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Generate value analysis report
        /// Include:
        /// - Most valuable product
        /// - Least valuable product
        /// - Average price
        /// - Median price
        /// - Products above average price
        /// </summary>
        public string GenerateValueReport()
        {
            // TODO: Calculate statistics
            StringBuilder sb = new StringBuilder();
            var mostValuable = products.OrderByDescending(item=>item.ProductPrice).First();
            var leastValuable = products.OrderBy(item => item.ProductPrice).First();
            decimal avg = products.Average(item => item.ProductPrice);
            var sorted = products.OrderBy(item=>item.ProductPrice).ToList();
            int count = sorted.Count();
            int mid = count / 2;
            decimal mediam = sorted[mid].ProductPrice;
            var productsAboveAvg = products.Where(item => item.ProductPrice > avg);

            sb.AppendLine("VALUE ANALYSIS REPORT");
            sb.AppendLine($"Most Valuable Product: {mostValuable?.ProductName} - {mostValuable?.ProductPrice:C}");
            sb.AppendLine($"Least Valuable Product: {leastValuable?.ProductName} - {leastValuable?.ProductPrice:C}");
            sb.AppendLine($"Average Price: {avg:C}");
            sb.AppendLine($"Median Price: {mediam:C}");
            sb.AppendLine("Products Above Average:");

            foreach (var item in productsAboveAvg)
            {
                sb.AppendLine($"- {item.ProductName} - {item.ProductPrice:C}");
            }
            return sb.ToString();
            //throw new NotImplementedException();
        }

        /// <summary>
        /// TODO: Generate report of expiring grocery products
        /// Include products expiring within daysThreshold
        /// </summary>
        public string GenerateExpiryReport(int daysThreshold)
        {
            // TODO: Find expiring grocery products
            List<Product> list = new List<Product>();
            StringBuilder sb = new StringBuilder();

            foreach(GroceryProduct item in products)
            {
               

                TimeSpan daystoExpires = DateTime.Today - item.ExpiryDate;
                if(daystoExpires.Days <= daysThreshold)
                {
                    list.Add(item);
                }
            }
            foreach(var item in list)
            {
                
                sb.Append(item.ToString());
                //sb.Append("\n");

            }

            //throw new NotImplementedException();
            return sb.ToString();
        }

        // ============ Additional Methods (Optional) ============

        /// <summary>
        /// TODO (Bonus): Search products with custom criteria
        /// </summary>
        public IEnumerable<Product> SearchProducts(Func<Product, bool> predicate)
        {
            // TODO: Implement custom search
            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO (Bonus): Apply discount to products in category
        /// </summary>
        public void ApplyCategoryDiscount(string category, decimal discountPercentage)
        {
            // TODO: Apply discount to all products in category
            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO (Bonus): Get total count of products
        /// </summary>
        public int GetTotalProductCount()
        {
            // TODO: Return total number of products
            throw new NotImplementedException();
        }

        /// <summary>
        /// TODO (Bonus): Get unique categories
        /// </summary>
        public IEnumerable<string> GetCategories()
        {
            // TODO: Return distinct categories
            throw new NotImplementedException();
        }
    }

}
