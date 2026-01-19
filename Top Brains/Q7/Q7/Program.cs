// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the Height");
int height = Convert.ToInt32(Console.ReadLine());
if (height < 150)
{
    Console.WriteLine("Short");
}
else if (height>=150 && height <180)
{
    Console.WriteLine("Average");
}
else if (height >= 180)
{
    Console.WriteLine("Tall");
}


