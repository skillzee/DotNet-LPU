// See https://aka.ms/new-console-template for more information
using Assignment1;

Console.WriteLine("Hello, World!");


System.Console.WriteLine("Enter the title");
string title = Console.ReadLine();
System.Console.WriteLine("Enter the author");
string author = Console.ReadLine();
System.Console.WriteLine("Enter the number of pages");
int numPages = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the due date");
DateTime dueDate = Convert.ToDateTime(Console.ReadLine());
System.Console.WriteLine("Enter the return date");
DateTime returnedDate = Convert.ToDateTime(Console.ReadLine());
System.Console.WriteLine("Enter the days to read");
int daysToRead = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter the daily late feeRate");
double dailyLateFeeRate = Convert.ToDouble(Console.ReadLine());


Book book = new Book(title, author, numPages, dueDate, returnedDate);

double avgPages = book.AveragePagesReadPerDay(daysToRead);
System.Console.WriteLine("Average Pages Read Per Day: " + avgPages);
double lateFee = book.CalculateLateFee(dailyLateFeeRate);
System.Console.WriteLine("Late Fee: " + lateFee);


