using System;

namespace Practice_Assignment;

public abstract class Transaction: IReportable
{

    // (Properties: Id, Date, Amount, Description).
    public int ID{get; set;}

    public DateTime Date{get; set;}

    public float Amount{get; set;}

    public string? Description {get; set;}

    public string GetSummary()
    {
        return $"The transaction done with ID: {ID} date {Date} amount {Amount} description {Description}";
    }
}
