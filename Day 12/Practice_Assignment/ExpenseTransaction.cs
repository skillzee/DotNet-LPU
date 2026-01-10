using System;

namespace Practice_Assignment;

public class ExpenseTransaction: Transaction
{
    public string? Category{get; set;}

    public override string GetSummary()
    {
        return $"The transaction done with ID: ${ID} date ${Date} amount ${Amount} description -> Amount Debited";
    }
}
