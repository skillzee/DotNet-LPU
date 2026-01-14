using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ServiceLibrary;
using System.Threading.Tasks;

namespace ServiceLogic
{

    [Doctor(Name ="Neha", CheckedOnDate ="22/04/2025")]
    [Doctor(Name = "Sashi", CheckedOnDate = "16/03/2025")]
    [Doctor(Name = "Neha", CheckedOnDate = "22/04/2025")]


    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            int num1;
            int num2;
            Console.WriteLine("Enter the first Number: ");
            num1 = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the second Number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            SomeLogic logic = new SomeLogic();

            int sum = logic.Addme(num1, num2);
            Console.WriteLine("The sum is " + sum);
            Console.ReadLine();

        }
    }
}
