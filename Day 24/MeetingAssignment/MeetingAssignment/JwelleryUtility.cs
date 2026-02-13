using System;
using System.Collections.Generic;

namespace MeetingAssignment
{
    public class JwelleryUtility
    {
        public Dictionary<string, string> GetJewelleryDetails(string id)
        {
            Dictionary<string, string> res = new Dictionary<string, string>();

            foreach (var item in Program.jewelleryDetails)
            {
                if (item.Value.Id == id)
                {
                    string value = item.Value.Type + "_" + item.Value.Material;
                    res.Add(id, value);
                    return res;
                }
            }

            return res; 
        }

        public Dictionary<string, Jwellery> UpdateJewelleryPrice(string id, int price)
        {
            Dictionary<string, Jwellery> res = new Dictionary<string, Jwellery>();

            foreach (var item in Program.jewelleryDetails)
            {
                if (item.Value.Id == id)
                {
                    item.Value.Price = price;
                    res.Add(id, item.Value);
                    return res;
                }
            }

            return res;
        }
    }
}
