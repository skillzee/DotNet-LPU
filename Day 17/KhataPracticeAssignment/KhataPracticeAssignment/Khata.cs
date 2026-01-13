using System;
using System.Collections.Generic;
using System.Text;

namespace KhataPracticeAssignment
{
    public class Khata
    {
        public Dictionary<string, int> products = new Dictionary<string, int>();


        public Khata(Dictionary<string, int> record)
        {
            products = record;
        }

        public int getTotal()
        {
            int sum = 0;
            foreach (var item in products)
            {
                sum += item.Value;
            }

            return sum;
        }



        /// <summary>
        ///     getRepeatAmount
        /// 	Returns the number of unique amounts that occur more than once.
        /// 	Each repeated amount should be counted only once.

        /// </summary>
        /// <returns></returns>

        public int getRepeatAmount()
        {
            int repeatedAmountCount = 0;
            HashSet<int> set = new HashSet<int>();
            foreach(var item in products)
            {
                if (set.Contains(item.Value)) {
                    repeatedAmountCount++;
                }
                else
                {
                    set.Add(item.Value);
                }
            }

            return repeatedAmountCount;
        }


        public void AddItem(string Name, int amount)
        {
            if (products.ContainsKey(Name))
            {
                Console.WriteLine("Product is already Added");
            }
            else
            {
                products.Add(Name, amount);
            }
        }



    }
 
}
