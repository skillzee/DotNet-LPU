// See https://aka.ms/new-console-template for more information
using Assessment2;

Console.WriteLine("Hello, World!");

Passenger p = new Passenger();

System.Console.Write("Enter the Passenger ID: ");

p.PassengerID = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Enter the Passenger Name: ");
p.PassengerName = Console.ReadLine();

System.Console.Write("Enter the Passenger Age: ");
p.Age = Convert.ToInt32(Console.ReadLine());

string travelType = String.Empty;
string travelClass = String.Empty;
float multiplier = 0f;

System.Console.WriteLine("Enter the Travel Type: 1 -> Bus\n 2->Train \n 3 -> Flight");
p.TravelType = Convert.ToInt32(Console.ReadLine());
switch (p.TravelType)
{
    case 1:
        travelType = "Bus";
        Console.WriteLine("Enter the class \n 1 for Sleeper \n 2 for Seater");
        int classType = Convert.ToInt32(Console.ReadLine());
        switch (classType)
        {
            case 1:
                travelClass = "Sleeper";
                multiplier = 1.2f;
                break;
            case 2:
                travelClass = "Seater";
                multiplier = 1.0f;
                break;
            default:
                break;
        }
        break;
    case 2:
        travelType = "Train";
        Console.WriteLine("Enter the class \n 1 for General \n 2 for Sleeper \n 3 for AC");
        int classTypeTrain = Convert.ToInt32(Console.ReadLine());
        switch (classTypeTrain)
        {
            case 1:
                travelClass = "General";
                multiplier = 1.0f;
                break;
            case 2:
                travelClass = "Sleeper";
                multiplier = 1.3f;
                break;
            case 3:
                travelClass = "AC";
                multiplier = 1.6f;
                break;
            default:
                break;
        }
        break;
    case 3:
        travelType = "Flight";
        Console.WriteLine("Enter the class \n 1 for Economy \n 2 for Business");
        int classTypeFlight = Convert.ToInt32(Console.ReadLine());
        switch (classTypeFlight)
        {
            case 1:
                travelClass = "Economy";
                multiplier = 2.5f;
                break;
            case 2:
                travelClass = "Business";
                multiplier = 3.5f;
                break;
            default:
                break;
        }

        break;

    default:
        break;
}

System.Console.Write("Enter the Base Fare: " );

p.BaseFare = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Are you gov Employee 1 for Yes 0 for No: " );

p.IsGovEmp = Convert.ToBoolean(Console.ReadLine());

double fareAfterClass = p.BaseFare * multiplier;

double discount = 0;

if (p.Age >= 60)
{
    discount = 30;
}
else if (p.IsGovEmp)
{
    discount = 15;
}else if (p.Age>=5 && p.Age<=12)
{
    discount = 50;
}
else
{
    discount = 0;
}


double finalFare = fareAfterClass - (discount/100 * fareAfterClass);


string bookingStatus = String.Empty;

if (finalFare >= 10000)
{
    if(p.TravelType == 3)
    {
        bookingStatus = "Confirmed";
    }
    else
    {
        bookingStatus = "Waiting List";
    }
}
else
{
    bookingStatus = "Confirmed";
}





// Displaying all the details Yahan krunga


Console.WriteLine($"Passenger ID: {p.PassengerID}, \n Name: {p.PassengerName} \n Travel Type: {travelType} \n Class: {travelClass}\n Base Fare: {p.BaseFare} \n Final Fare: {finalFare} \n Discount Applied: {discount}% \n Booking Status: {bookingStatus}");













