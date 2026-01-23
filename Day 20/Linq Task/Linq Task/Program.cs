// See https://aka.ms/new-console-template for more information
using Linq_Task;
using System.Xml.Linq;

Console.WriteLine("Hello, World!");

//create an employee class having name and salary.
//add them to the list and fin the person with highest salary

List<Employee> employess = new List<Employee>()
{
    new Employee{ Name = "Parth", Salary = 10000},
    new Employee {Name = "Raju", Salary = 20000},
    new Employee {Name = "Shaym", Salary = 30000}

};


var personWithHighestSalary = from member in employess
                              where member.Salary == employess.Max(mem => mem.Salary)
                              select member;

foreach (var item in personWithHighestSalary)
{
    Console.WriteLine(item.Name);
}
