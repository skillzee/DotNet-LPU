// See https://aka.ms/new-console-template for more information
using Q4;
using System.Text.Json;
using System.Text.Json.Nodes;

Console.WriteLine("Hello, World!");


Console.WriteLine("Write the number of items you want to add");
int n = Convert.ToInt32(Console.ReadLine());

string[] namesAndScore = new string[n];

Console.WriteLine("Enter the data: ");

for (int i = 0; i < n; i++)
{
    namesAndScore[i] = Console.ReadLine();
}

Console.WriteLine("Enter the minScore: ");
int minScore = Convert.ToInt32(Console.ReadLine());

List<Student> students = new List<Student>();

foreach(var names in namesAndScore)
{
    string[] Name = names.Split(':');
    Student student = new Student();
    student.Name = Name[0];
    student.Score = Convert.ToInt32(Name[1]);
    students.Add(student);
}


var filtered = from Student student in students
               where student.Score >= minScore
               orderby student.Score descending, student.Name ascending
               select student;

string json = JsonSerializer.Serialize(filtered);
Console.WriteLine(json);






