using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLogic
{

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property| AttributeTargets.Method, AllowMultiple =true)]
    public class DoctorAttribute:Attribute
    {
        public string Name { get; set; }
        public string CheckedOnDate { get; set; }
    }
}
