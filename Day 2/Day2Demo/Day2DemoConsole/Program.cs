// See https://aka.ms/new-console-template for more information
using Day2DemoConsole;


static void Menu()
{
    Console.WriteLine("1. Add Student Details");
    Console.WriteLine("2. Update Student Details");
    Console.WriteLine("3. Drop Student Details");
}

Console.WriteLine("Hello, World!");


Student sObj = new Student(123, "Alok", "Delhi");


sObj.DisplayDetails(sObj);


sObj = new Student(123, "Alok", "Chenbai");
sObj.DisplayDetails(sObj);


string[] cities = {"Pune", "Mumbai", "Bangalore", "Chennai"};


do
{
    Menu();
    Console.WriteLine("Enter your choice");
    int choice = Convert.ToInt32(Console.ReadLine());
    switch (choice)
    {
        case 1:
            {
                break;
            }
        case 2:
            {
                break;
            }
        case 3:
            {
                break;
            }
    }


} while (true);


int i = 0;
while (i < cities.Length)
{
    System.Console.WriteLine(cities[i]);

    i++;
}
