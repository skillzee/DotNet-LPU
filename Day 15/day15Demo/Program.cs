// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");


DirectoryDemo dObj = new DirectoryDemo();
// dObj.DirectoryDemoFunc("LPU"); //Folder created in bin



// dObj.DriveInfoFunc("C:\\");

// dObj.PathDemoFunc();\



FileStreamDemo fsDemoObj = new FileStreamDemo();
// fsDemoObj.createFile(@"D:\CapGemini Training LPU\Sample.txt");
fsDemoObj.ReadFile(@"D:\CapGemini Training LPU\Sample.txt");