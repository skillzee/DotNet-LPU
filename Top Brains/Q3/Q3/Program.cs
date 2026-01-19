// See https://aka.ms/new-console-template for more information


Console.WriteLine("Write n: ");

int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Write upto: ");
int upto = Convert.ToInt32(Console.ReadLine());


for(int i =1; i<= upto; i++)
{
    Console.WriteLine(n * i);
}


