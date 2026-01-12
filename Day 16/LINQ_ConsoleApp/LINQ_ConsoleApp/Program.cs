using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_ConsoleApp
{
    internal class Program
    {
        public static void LinqToObjectDemo()
        {
            int[] numArray = { 10, 2, 12, 34, 45, 65, 23, 66, 48, 8, 27 };
            string[] nameArray = { "Alok", "Rajat", "Semeet", "Priya", "Ayush", "Harshita", "Himanshu", "Mahi", "Mandabi", "Gaurav", "Yash", "Mahesh", "Teja", "Sai" };

            //foreach (var item in numArray)
            //{
            //    if (item % 2 == 0)
            //    {
            //        Console.WriteLine(item);
            //    }
            //}


            //LINQ Query
            Console.WriteLine("Enter the name to Seacrh");

            string dataToSearch = Console.ReadLine();



            //Query Syntax
            //var results = from data in nameArray
            //              where data==dataToSearch
            //              select data;

            //Console.WriteLine(results);

            //Method Syntax

            var results = nameArray.Where(n => n == dataToSearch);


            foreach (var item in results)
            {
                Console.WriteLine(item);

            }
            
        }


        public static void LinqToObjectDemoOnCustomType()
        {
            List<Customer> custList = new List<Customer>()
            {
                new Customer{CustomerId = 101, Name = "Alok", City = "Pune" },
                new Customer(){CustomerId = 102, Name = "Alia", City = "Mumbai" },
                new Customer{CustomerId = 103, Name = "Dheeraj", City = "Pune" },
                new Customer{CustomerId = 104, Name = "Danish", City = "Pune" },
                new Customer{CustomerId = 105, Name = "Smita", City = "Delhi" },
                new Customer{CustomerId = 106, Name = "Naveev", City = "Pune" },
                new Customer{CustomerId = 107, Name = "Parchi", City = "Delhi" },
                new Customer{CustomerId = 108, Name = "Megha", City = "Mumbai" },
            };

            //Anonymous Object
            var data = new { OrderID = 101, OrderName = "Flower" };
            //Console.WriteLine(data.GetType());

            var reults = custList.Where(cust => cust.City == "Mumbai");

            var result1 = custList.Find(cust => cust.City == "Delhi");

            foreach(var cust in reults)
            {
                Console.WriteLine($"{cust.CustomerId} \t {cust.Name} \t {cust.City}");
            }





        }



        public static void LamdaLookup()
        {
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            var query = numbers.ToLookup(i => i % 2);

            foreach(IGrouping<int, int> group in query)
            {
                Console.WriteLine("Key "+ group.Key);
                foreach(int number in group)
                {
                    Console.WriteLine(number); 
                }

            }
        }

        public static void LamdaLookupStudentList()
        {

            StudentRepo studentRepo = new StudentRepo();

            List<Student> tempList = studentRepo.GetAllStudents();

            var query = tempList.ToLookup(s => s.Gender == "Male");

            foreach (IGrouping<bool, Student> group in query)
            {
                int totalFees = 0;
                Console.WriteLine("Key:  " + (group.Key?"Male": "Female"));
                foreach (Student st in group)
                {
                    Console.WriteLine($"{st.Name}");
                    totalFees += st.Fees;
                }

                Console.WriteLine("Total Fees Paid: "+ totalFees);



                var maleFeesPaid = group.Select(s => s.Fees);
                var sum = maleFeesPaid.Where(s=> s>1000).Sum();
                Console.WriteLine("Megha "+ sum);
            }
        }

        static void Main(string[] args)
        {

            //LinqToObjectDemo();
            //LinqToObjectDemoOnCustomType();
            //LamdaLookupStudentList();

            StudentRepo studentRepo = new StudentRepo();

            List<Student> tempList = studentRepo.GetAllStudents();

            var total = tempList.Where(s => s.Gender == "Male");
            var maleTotal = total.Select(s=> s.Fees);

            foreach (var t in maleTotal)
            {
                Console.WriteLine(t);
            }
            //Console.WriteLine(maleTotal);
        }
    }
}
