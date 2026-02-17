// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

//Marriage compatibilty by names

static int helper(string a, string b)
{
    a = a.ToLower();
    b = b.ToLower();

    HashSet<char> set = new HashSet<char>();
    foreach(char ch in b)
    {
        if (a.Contains(ch))
        {
            set.Add(ch);
        }
    }

    return b.Length - set.Count;
 }

Console.WriteLine("Enter the boy name: ");
string a = Console.ReadLine();
Console.WriteLine("Enter the girl name: ");
string b = Console.ReadLine();

int diffLetters = helper(a, b); // Compatibilty Value
Console.WriteLine("Compatibilty number is: "+ diffLetters);
