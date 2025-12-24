using System;

namespace Assignment1;

public class Book
{
    string? title;
    string? author;
    int numPages;
    DateTime dueDate;
    DateTime returnedDate;

    public Book()
    {
        
    }

    //  author, numPages, dueDate, returnedDate
    public Book(string title, string author, int numPages, DateTime dueDate, DateTime returnedDate )
    {
        this.title = title;
        this.author = author;
        this.numPages = numPages;
        this.dueDate = dueDate;
        this.returnedDate = returnedDate;

    }


    public double AveragePagesReadPerDay(int daysToRead)
    {
        double avg = numPages/daysToRead;
        return avg;
    }

    public double CalculateLateFee(double dailyLateFeeRate)
    {
        TimeSpan lateDays = returnedDate - dueDate;
        double fine = lateDays.Days * (double)dailyLateFeeRate;
        return fine;


    }



}
