// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Enter the starting digit: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Enter the last digit: ");
int b = Convert.ToInt32(Console.ReadLine());

int count = 0;
for(int i = a; i<=b; i++)
{
    if (IsLucky(i))
    {
        count++; 
    }
}

Console.WriteLine("Total numbers are: "+ count);



bool IsLucky(int i)
{
    int secondNum = i * i;
    int firstNum = i;

    int firstDigitSum = helper(firstNum);
    int secondDigitSum = helper(secondNum);

    if(firstDigitSum*firstDigitSum ==  secondDigitSum) return true;

    return false;
}


int helper(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum += num % 10;
        num /= 10;
    }
    return sum;

}