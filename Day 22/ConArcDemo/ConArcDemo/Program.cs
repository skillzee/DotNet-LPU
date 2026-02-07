using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConArcDemo
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            StudentDAL dal = new StudentDAL();
            List<Student> tempList = dal.ShowAllStudents();
            foreach(Student item in tempList)
            {
                Console.WriteLine($"{item.RollNo} -> {item.Name}");
            }



            List<Student> search = dal.SearchByName("Absk");
            foreach (Student item in search)
            {
                Console.WriteLine($"{item.RollNo} -> {item.Name}");
            }
        }
    }
}
