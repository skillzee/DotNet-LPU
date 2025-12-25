// Q6. Given an integer array, sum only positive numbers until you reach 0.
// - If an element is 0, stop processing (break).
// - If an element is negative, ignore it (continue).
// Input: nums (int[])
// Output: sum (int)
// Constraints:
// 0 <= nums.Length <= 1e5
// -1e9 <= nums[i] <= 1e9"

System.Console.WriteLine("Write the number of elements : ");
int n = Convert.ToInt32(Console.ReadLine());
int[] arr = new int[n];

for(int i = 0; i<n; i++)
{
    arr[i] = Convert.ToInt32(Console.ReadLine());
}


int sum = 0;

for(int i = 0; i<n; i++)
{
    if(arr[i] == 0) break;

    if(arr[i]<0) continue;


    sum+=arr[i];
}


System.Console.WriteLine(sum);





