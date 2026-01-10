using System;

namespace Practice_Assignment;

public class IncomeTransaction: Transaction, IReportable
{
    public string? Source{get; set;}

    public override string GetSummary()
    {
        return $"The transaction done with ID: ${ID} date ${Date} amount ${Amount} description -> Amonunt Credited ";
    }
}
