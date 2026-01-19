// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("a: ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("b: ");
int b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("c: ");
int c = Convert.ToInt32(Console.ReadLine());

int largest = 0;

if(a >= b)
{
    if (a >= c) largest = a;
}

if (b >= a)
{
    if (b >= c) largest = b;
}

if (c >= a)
{
    if (c >= b) largest = c;
}

Console.WriteLine("The Largest Number is: "+ largest);
