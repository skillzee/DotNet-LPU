using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_Commerece
{
    public class ShoppingCart<T> where T: Product
    {
        private Dictionary<T, int> _cartItems = new Dictionary<T, int>();

        // Add product to cart
        public void AddToCart(T product, int quantity)
        {
            // TODO: Add or update quantity in dictionary
            if (_cartItems.ContainsKey(product))
            {
                _cartItems[product] += quantity;
            }
            else
            {
                _cartItems.Add(product, quantity);
            }


        }

        // Calculate total with discount delegate
        public double CalculateTotal(Func<T, double, double> discountCalculator = null)
        {
            double total = 0;
            foreach (var item in _cartItems)
            {
                double price = item.Key.Price * item.Value;
                if (discountCalculator != null)
                    price = discountCalculator(item.Key, price);

                total += price;
            }
            return total;
        }

        // Get top N expensive items using LINQ
        public List<T> GetTopExpensiveItems(int n)
        {
            // TODO: Use LINQ OrderByDescending and Take
            var res = _cartItems.Keys.OrderByDescending(x=>x.Price).Take(n).ToList();

            return res;

        }

    }
}
