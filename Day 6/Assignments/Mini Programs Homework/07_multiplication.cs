// Q7. Return the multiplication table row for a number n from 1..upto.
// Example: n=3, upto=5 -> [3,6,9,12,15]
// Input: n (int), upto (int)
// Output: row (int[])
// Constraints:
// 0 <= upto <= 1e5
// -1e4 <= n <= 1e4


System.Console.Write("n: ");
int n = Convert.ToInt32(Console.ReadLine());
System.Console.Write("upto: ");
int upto = Convert.ToInt32(Console.ReadLine());

int[] arr = new int[upto+1];

for(int i = 1; i<=upto; i++)
{
    arr[i] = n*i;
}

foreach (int a in arr)
{
    System.Console.WriteLine(a);
}





