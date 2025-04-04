
using System;
using System.IO;
using System.Threading;

namespace ClassDir
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? path = null;
            if (OperatingSystem.IsAndroid())
            {
                path = "/storage/emulated/0/Documents/";
            } else if(OperatingSystem.IsWindows())
            {
                path = Environment.GetEnvironmentVariable("USERPROFILE");
                path += @"\Desktop\";
            } else
            {
                throw new NotImplementedException("OS not supported");
            }
            
            Directory.SetCurrentDirectory(path);
            // Console.WriteLine($"pwd: {Environment.CurrentDirectory}");
            Console.WriteLine($"pwd: {Directory.GetCurrentDirectory()}");
            
            // Get all files in the current directory
            string[] files = Directory.GetFiles(".");
            Array.Sort(files); // Sort alphabetically
            
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("files: ");
            Console.ResetColor();
            Thread.Sleep(5000);
            Array.ForEach(files, s => Console.WriteLine(s));
        }
    }
}