// See https://aka.ms/new-console-template for more information
using Practice_Assignment;

Console.WriteLine("This is a Ledger Application");

Ledger<IncomeTransaction> income = new Ledger<IncomeTransaction>();
Ledger<ExpenseTransaction> expense = new Ledger<ExpenseTransaction>();
List<Transaction> transactions = new List<Transaction>();

System.Console.WriteLine("To Type Income Press 1. To Type Expense Press 2. Press Any other Key To Exit");
int option = Convert.ToInt32(Console.ReadLine());


// Main Success Scenario (Steps)
// 1.	The user creates a Ledger<IncomeTransaction> to track funds received from the main office.
// 2.	The user records a $500 replenishment from "Main Cash".
// 3.	The user creates a Ledger<ExpenseTransaction> to track daily spends.
// 4.	The user records an expense of $20 for "Stationery" and $15 for "Team Snacks".
// 5.	The system uses a generic method to display the total from both ledgers.
// 6.	The user calculates the Net Balance (Total Income - Total Expenses

while(option==1 || option==2)
{
    if(option==1)
    {
        IncomeTransaction incomeTransaction = new IncomeTransaction();

        System.Console.WriteLine("Enter the ID:");
        incomeTransaction.ID = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Date:");
        incomeTransaction.Date = Convert.ToDateTime(Console.ReadLine());

        System.Console.WriteLine("Enter the Amount:");
        incomeTransaction.Amount = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Source:");
        incomeTransaction.Source = Console.ReadLine();

        income.AddEntry(incomeTransaction);
        transactions.Add(incomeTransaction);
    }
    else if(option==2)
    {
        ExpenseTransaction expenseTransaction = new ExpenseTransaction();

        System.Console.WriteLine("Enter the ID:");
        expenseTransaction.ID = Convert.ToInt32(Console.ReadLine());

        System.Console.WriteLine("Enter the Date:");
        expenseTransaction.Date = Convert.ToDateTime(Console.ReadLine());

        System.Console.WriteLine("Enter the Amount:");
        expenseTransaction.Amount = float.Parse(Console.ReadLine());

        System.Console.WriteLine("Enter the Category:");
        expenseTransaction.Category = Console.ReadLine();

        expense.AddEntry(expenseTransaction);
        transactions.Add(expenseTransaction);
    }

    System.Console.WriteLine("To Type Income Press 1. To Type Expense Press 2. Press Any other Key To Exit");
    option = Convert.ToInt32(Console.ReadLine());
}



System.Console.WriteLine("The Total Income is: "+ income.CalculateTotal());
System.Console.WriteLine("The Total Expense is: "+ expense.CalculateTotal());

System.Console.WriteLine("The net balance is: "+ (income.CalculateTotal() - expense.CalculateTotal()));



System.Console.WriteLine("The Transaction Summary is below: ");

foreach(Transaction tr in transactions)
{
    Console.WriteLine(tr.GetSummary());
}
