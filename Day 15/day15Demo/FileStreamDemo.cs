using System.IO;


public class FileStreamDemo
{

    FileStream fs = null;
    public void createFile(string fileName)
    {
        fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        StreamWriter sw = new StreamWriter(fs);
        sw.WriteLine("This is just a sample file for file io demo");
        sw.Close();
        fs.Close();
    }


    public void ReadFile(string fileName)
    {
        fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        StreamReader sr = new StreamReader(fs);
        System.Console.WriteLine(sr.ReadToEnd());
        sr.Close();
        fs.Close();


    }
}