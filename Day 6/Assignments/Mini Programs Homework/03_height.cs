// Q3. Given a person's height in centimeters, return the height category:
// - ""Short""  : height < 150
// - ""Average"": 150 <= height < 180
// - ""Tall""   : height >= 180
// Input: heightCm (int)
// Output: category (string)
// Constraints:
// 0 <= heightCm <= 300"



System.Console.WriteLine("Enter the height: ");
int height = Convert.ToInt32(Console.ReadLine());

if (height < 150)
{
    System.Console.WriteLine("Short");
}
else if (height >= 150 && height < 180)
{
    System.Console.WriteLine("Average");
}
else
{
    System.Console.WriteLine("Tall");
}