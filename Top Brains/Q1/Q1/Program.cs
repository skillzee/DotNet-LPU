// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("Hello, World!");
Console.WriteLine("Write the first word: ");
string? first_word = Console.ReadLine();
Console.WriteLine("Write the second word: ");
string? second_word = Console.ReadLine();

string? output = String.Empty;


first_word = first_word.ToLower();
second_word = second_word.ToLower();


string vowels = "aeiou";


StringBuilder filtered = new StringBuilder();



foreach(char ch in first_word)
{
    if(!vowels.Contains(ch) && second_word.Contains(ch))
    {
        continue;
    }
    else
    {
        filtered.Append(ch); 
    }

}



StringBuilder result = new StringBuilder();

for(int i = 0; i < filtered.Length; i++)
{
    if (i == 0 || filtered[i] != filtered[i - 1])
    {
        result.Append(filtered[i]);
    }
}


Console.WriteLine(result.ToString());
