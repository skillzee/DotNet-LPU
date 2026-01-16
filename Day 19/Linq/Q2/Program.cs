using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Q2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            List<Employee> employees = new List<Employee>()
            {
                new Employee{Name = "Parth", ID = 101},
                new Employee{Name = "MEgha", ID = 102},
                new Employee{Name = "Nisha", ID = 103}
            };
            


            var oneEmp = from emp in employees
                         where emp.ID == 101
                         select emp;

            foreach (var emp in oneEmp)
            {
                Console.WriteLine(emp.Name);
                Console.WriteLine(emp.ID);
            }


        }
    }
}
