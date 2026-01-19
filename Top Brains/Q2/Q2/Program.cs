// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Console.WriteLine("Enter the Fisrt Number: ");
int first = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter the Second Number: ");
int second = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Before Swapping first word is {first} and second word is {second}");

changeViaRef(ref first, ref second);

Console.WriteLine($"After Swapping uisng ref first word is {first} and second word is {second}");


int num1Final;
int num2Final;
changeViaOut(first, second, out num1Final, out num2Final);

Console.WriteLine($"After Swapping uisng out first word is {num1Final} and second word is {num2Final}");


void changeViaRef(ref int first, ref int second)
{
    first = first + second;
    second = first - second;
    first = first - second;
}


void changeViaOut(int first, int second, out int num1Final, out int num2Final)
{
    num1Final = second;
    num2Final = first;

}

