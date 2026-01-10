using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegationDemo
{
    internal interface IRepo<T>
    {
        T SearchByID(int ID);
        bool Add(T obj);



    }
}
