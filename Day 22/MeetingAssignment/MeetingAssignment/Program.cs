using System;
using System.Collections.Generic;
using MeetingAssignment;

public class Program
{
    public static Dictionary<int, Student> studentDetails;

    public static void Main()
    {
        studentDetails = new Dictionary<int, Student>()
        {
            { 1, new Student { ID = "ST01", Name = "Alice", Course = "DataScience", Marks = 85 } },
            { 2, new Student { ID = "ST02", Name = "Bob", Course = "AI", Marks = 78 } }
        };

        StudentUtility utility = new StudentUtility();
        bool running = true;

        while (running)
        {
            Console.WriteLine("1. Get Student Details");
            Console.WriteLine("2. Update Marks");
            Console.WriteLine("3. Exit");
            Console.WriteLine("Enter your choice");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    Console.WriteLine("Enter the student id");
                    string id = Console.ReadLine();

                    var details = utility.GetStudentDetails(id);

                    
                    
                     foreach (var item in details)
                     {
                         Console.WriteLine(item.Key + "   " + item.Value);
                     }
                  
                    break;

                case 2:
                    Console.WriteLine("Enter the student id");
                    string updateId = Console.ReadLine();

                    Console.WriteLine("Enter the marks");
                    int marks = int.Parse(Console.ReadLine());

                    var updated = utility.UpdateStudentMarks(updateId, marks);

                    Console.WriteLine("Updated Student");
                    foreach (var item in updated)
                    {
                        Console.WriteLine(
                            item.Key + " " +
                            item.Value.Name + " " +
                            item.Value.Course + " " +
                            item.Value.Marks
                        );
                    }

                    break;

                case 3:
                    Console.WriteLine("Thank you");
                    running = false;
                    break;
            }
        }
    }
}
