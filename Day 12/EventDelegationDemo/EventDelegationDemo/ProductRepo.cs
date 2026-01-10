using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegationDemo
{
    internal class ProductRepo : IRepo<Product>
    {
        public bool Add(Product obj)
        {
            throw new NotImplementedException();
        }

        public Product SearchByID(int ID)
        {
            throw new NotImplementedException();
        }
    }
}
