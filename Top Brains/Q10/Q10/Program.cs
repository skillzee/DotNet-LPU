// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


Console.WriteLine("Enter n: ");
int n = Convert.ToInt32(Console.ReadLine());


object[] arr = new object[n];

for (int i = 0; i < n; i++)
{
    arr[i] = Console.ReadLine();
}


int sum = 0;

for(int i = 0; i<n; i++)
{
    string ch = (string)arr[i];
    if (ch.All(Char.IsDigit))
    {
        sum += Int32.Parse(ch);
    }
}

Console.WriteLine(sum);
