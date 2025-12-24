using System;

namespace Assignment2;

public class CabDetails: Cab
{

// in class CabDetails, implement the below-given methods and also Inherit class Cab.
//   Method
//  Description
//    public bool ValidateBookingID()
//  This method is used to validate the booking id.
// Conditions :
// 1. Booking id Length should be 6.
// 2. The id should have AC before the character @
// 3. There should be 3 digits after the character @.
// For Example : AC@123
// The above conditions are passed then return true, Otherwise return false.
//    public double CalculateFareAmount()
//  This method is used to calculate the fare of the cab bookings based on the cab type and return the fare amount with two decimal places.
//  Refer the below given procedures to calculate fare.
//  Hint : Use Math.Floor
// Formula :
// Fare = Distance * Price per km + Waiting Charge
// Waiting Charge = Square root of Waiting Time
//     Cab Type
//    Price per km
//      Hatchback
//    10
//      Sedan
//    20
//      SUV
//    30
//   Note : Cab type is case sensitive.

    bool isAC(string bookingID)
    {
        int flag = 0;
        int idx = bookingID.IndexOf('@');
        for(int i = 0; i<idx; i++)
        {
            if(bookingID[i] == 'A' || bookingID[i] == 'C')
            {
                flag++;
            }
        
        }
        if (flag >= 2)
        {
            return true;
        }

        return false;
    }

    bool is3Digit(string bookingID)
    {
        int idx = BookingID.IndexOf('@');

        int len = BookingID.Length;
        if(len-idx-1 == 3) return true;

        return false; 
    }

    public bool ValidateBookingID()
    {
        if(BookingID.Length == 6 && isAC(BookingID)  && is3Digit(BookingID))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public double CalculateFareAmount()
    {
        int pricePerKm= 0;
        if(CabType == "Hachback") pricePerKm = 10; 
        if(CabType == "Sedan") pricePerKm= 20; 
        if(CabType == "SUV") pricePerKm= 30; 
        double fareAmount = Distance * pricePerKm + Math.Sqrt(WaitingTime);

        return Math.Round(fareAmount, 2);
    }







}
