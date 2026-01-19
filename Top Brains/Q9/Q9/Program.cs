// See https://aka.ms/new-console-template for more information
using System;

Console.WriteLine("Hello, World!");


Console.WriteLine("Initial Balance: ");
int initialBalance = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Number of transactions: ");
int n = Convert.ToInt32(Console.ReadLine());
int[] transactions = new int[n];

for (int i = 0; i < n; i++)
{
    transactions[i] = Convert.ToInt32(Console.ReadLine());
    if (transactions[i] > 0)
    {
        initialBalance += transactions[i];
    }
    if (transactions[i] < 0) {
        if (initialBalance < transactions[i]) continue;
        initialBalance += transactions[i];
    }
}


Console.WriteLine("Final Balance "+ initialBalance);



