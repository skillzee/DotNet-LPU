// See https://aka.ms/new-console-template for more information
using Assignment2;

Console.WriteLine("Hello, World!");


// In Program class - Main method,
// 1.  Get the BookingID from the user.
// 2.  Call the ValidateBookingID method and if it returns true, then get the CabType, Distance and WaitingTime from the user, and move on to step 3. If it returns false, then display Invalid booking id
// 3.  Use the values in method CalculateFareAmount and display the result as per the Sample Output.
// Note:
// Keep the properties, methods and classes as public.
// Please read the method rules clearly.
// Do not use Environment.Exit() to terminate the program.
// Do not change the given code template.
// Sample Input 1:
//  Enter the booking id
// AC@234
// Enter the cab type
// SUV
// Enter the distance in km
// 30
// Enter the waiting time in minutes
// 15



System.Console.WriteLine("Enter the booking id");
string bookingID = Console.ReadLine();
CabDetails cabDetails = new CabDetails();
cabDetails.BookingID = bookingID;
if(cabDetails.ValidateBookingID())
{
    System.Console.WriteLine("Enter the cab type");
    cabDetails.CabType = Console.ReadLine();
    System.Console.WriteLine("Enter the distance in km");
    cabDetails.Distance = Convert.ToDouble(Console.ReadLine());
    System.Console.WriteLine("Enter the waiting time in minutes");
    cabDetails.WaitingTime = Convert.ToInt32(Console.ReadLine());

    double fareAmount = cabDetails.CalculateFareAmount();
    System.Console.WriteLine("The fare amount is: " + fareAmount);
}
else
{
    System.Console.WriteLine("Invalid booking id");
}
