using System.IO;


public class DirectoryDemo
{
    public void DirectoryDemoFunc(string DirectoryName)
    {
        if (Directory.Exists(DirectoryName))
        {
            Console.WriteLine("Folder Already Exists");
        }
        else
        {
            Directory.CreateDirectory(DirectoryName);
            System.Console.WriteLine("Folder Created");
        }
    }


    public void DriveInfoFunc(string driveName)
    {
        DriveInfo driveInfo = new DriveInfo(driveName);
        System.Console.WriteLine($"Drive name {driveInfo.Name}");
        System.Console.WriteLine($"Drive FilesSysttem {driveInfo.DriveType}");
        System.Console.WriteLine($"Drive Size {driveInfo.TotalSize/(1024*1024*1024)}");
        System.Console.WriteLine($"Drive Free Space {driveInfo.AvailableFreeSpace/(1024*1024*1024)}");
    }



    public void PathDemoFunc()
    {
        string s = @"D:\AWS";
        System.Console.WriteLine(Path.GetFileName(s));
        System.Console.WriteLine(Path.GetTempPath());
    }
}