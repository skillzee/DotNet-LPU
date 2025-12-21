// See https://aka.ms/new-console-template for more information
// Student management system
// Console.WriteLine("Hello, World!");

using SMSApp;

StudentBL sBLObj = new StudentBL();

sBLObj.AcceptSudentDetails();
// sBLObj.CalcTotal();
// sBLObj.CalAvg();
int t1;
float p1;

sBLObj.calcResult(out t1, out p1);

// System.Console.WriteLine($"Total {sBLObj.CalcTotal()}");
// System.Console.WriteLine($"Perdentage {sBLObj.CalAvg()}");
System.Console.WriteLine($"Total {t1}");
System.Console.WriteLine($"Percentage {p1}");
