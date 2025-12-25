// Q1.Write a method that returns the area of a circle for a given radius.
// Round the result to 2 decimal places (MidpointRounding.AwayFromZero).
// Input: radius (double)
// Output: area (double)
// Constraints:
// 0 <= radius <= 1e6"



System.Console.WriteLine("Enter the radius: ");
int radius = Convert.ToInt32(Console.ReadLine());

double area = Math.PI * radius * radius;
System.Console.WriteLine("The area is :"+ Math.Round(area, 2, MidpointRounding.AwayFromZero));

