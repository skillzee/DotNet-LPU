// Q4. Write a method that returns the largest of three integers using conditional logic.
// Input: a (int), b (int), c (int)
// Output: largest (int)
// Constraints:
// -1e9 <= a,b,c <= 1e9"

System.Console.WriteLine("a: ");
int a = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("b: ");
int b = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("c: ");
int c = Convert.ToInt32(Console.ReadLine());

if (a >= b && a >= c)
{
    System.Console.WriteLine("Largest is: " + a);
}
else if (b >= a && b >= c)
{
    System.Console.WriteLine("Largest is: " + b);
}
else
{
    System.Console.WriteLine("Largest is: " + c);
}