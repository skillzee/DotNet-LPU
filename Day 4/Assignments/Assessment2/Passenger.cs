using System;

namespace Assessment2;

public class Passenger
{
    int passengerID;
    string? passengerName;
    int age;
    int travelType;
    double busFare;
    bool isGovEmployee;

    public int PassengerID{get; set;}
    public string? PassengerName{get; set;}
    public int Age
    {
        get
        {
            return age;
        }
        set
        {
            if (value < 5)
            {
                throw new Exception("Free Ticket – No Booking Required");
            }else if (value > 80)
            {
                throw new Exception("'Medical Clearance Required");

            }
            else
            {
                age = value;
            }

        }
    }
    public int TravelType{get; set;}
    public double BaseFare{get; set;}
    public bool IsGovEmp{get; set;}






}
