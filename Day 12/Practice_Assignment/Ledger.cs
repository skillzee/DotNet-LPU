using System;

namespace Practice_Assignment;


// . The Ledger Logic (Generics & Collections)
// •	Generic Class: Ledger<T> where T : Transaction.
// •	Storage: Internal List<T> to hold the transaction history.
// •	Methods:
// o	AddEntry(T entry): Adds a transaction.
// o	GetTransactionsByDate(DateTime date): Returns a filtered list.
// o	CalculateTotal(): Uses LINQ or a loop to sum up the Amount



public class Ledger<T> where T : Transaction
{

    List<T> transactions = new List<T>();

    public void AddEntry(T entry)
    {
        transactions.Add(entry);
    }



    public void GetTransactionsByDate(DateTime date)
    {
        List<T> transactionsByDate = new List<T>();

        foreach(T tr in transactions)
        {
            if(tr.Date == date)
            {
                transactionsByDate.Add(tr);
            }
        }

        foreach(T tr in transactionsByDate)
        {
            System.Console.WriteLine(tr);
        }
    }


    public int CalculateTotal()
    {
        float totalSum = 0;

        foreach(T tr in transactions)
        {
            totalSum+=tr.Amount;
        }



        return (int)totalSum;
    }

}
