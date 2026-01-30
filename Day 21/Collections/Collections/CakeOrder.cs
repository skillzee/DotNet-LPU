using System;
using System.Collections.Generic;
using System.Text;

namespace Collections
{
    public class CakeOrder
    {
        public Dictionary<string, double> orderMap = new Dictionary<string, double>();

        public void AddOrderDetails(string orderId, double cakeCost)
        {
            orderMap[orderId] = cakeCost; 
        }


        public Dictionary<string, double> findOrdersAboveSpecifiedCost(double  cakeCost)
        {
            Dictionary<string, double> filtered = new Dictionary<string, double>();

            foreach (var order in orderMap)
            {
                if (order.Value > cakeCost)
                {
                    filtered[order.Key] = order.Value;
                }
            }


            return filtered;
        }
            
    }
}
