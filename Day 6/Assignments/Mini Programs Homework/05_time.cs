// Q5. Convert a number of seconds into a string formatted as m:ss.
// Seconds must be 2 digits (leading zero if needed).
// Input: totalSeconds (int)
// Output: formatted (string)
// Examples:
// 125 -> ""2:05""
// 60  -> ""1:00""
// Constraints:
// 0 <= totalSeconds <= 1e9"


System.Console.WriteLine("Enter the number of totalSeconds: ");
int totalSeconds = Convert.ToInt32(Console.ReadLine());
int min = totalSeconds/60;
int remainingSeconds = totalSeconds % 60;

string formatted = min.ToString() + ":" + remainingSeconds.ToString("D2");


System.Console.WriteLine(formatted);

