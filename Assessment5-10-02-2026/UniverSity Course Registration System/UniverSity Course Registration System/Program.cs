using System;
using System.Collections.Generic;
using System.Linq;

namespace University_Course_Registration_System
{
     // =========================
    // Program (Menu-Driven)
    // =========================
    class Program
    {
        static void Main()
        {
            UniversitySystem system = new UniversitySystem();
            bool exit = false;

            Console.WriteLine("Welcome to University Course Registration System");

            while (!exit)
            {
                Console.WriteLine("\n1. Add Course");
                Console.WriteLine("2. Add Student");
                Console.WriteLine("3. Register Student for Course");
                Console.WriteLine("4. Drop Student from Course");
                Console.WriteLine("5. Display All Courses");
                Console.WriteLine("6. Display Student Schedule");
                Console.WriteLine("7. Display System Summary");
                Console.WriteLine("8. Exit");

                Console.Write("Enter choice: ");
                string choice = Console.ReadLine();

                try
                {
                    switch(choice)
                    {
                        case "1":
                            Console.WriteLine("Enter the course code");
                            int code = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Name");
                            string name = Console.ReadLine();
                            Console.WriteLine("Enter the credits");
                            int credits = Int32.Parse(Console.ReadLine());
                            Console.WriteLine("Enter the Capacity");
                            int capacity = Int32.Parse(Console.ReadLine());
                            
                            Console.WriteLine("Enter the pre-requistes");
                            string pre = Console.ReadLine();
                            List<string> list = new List<string>();
                            list = pre.Split(",");

                            break;
                    }
                    // TODO:
                    // Implement menu handling logic using switch-case
                    // Prompt user inputs
                    // Call appropriate UniversitySystem methods
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}");
                }
            }
        }
    }
}

