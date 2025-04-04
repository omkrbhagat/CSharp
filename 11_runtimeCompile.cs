using System;
using System.IO;

namespace RuntimeCompile_v1
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? path = null;
            if(OperatingSystem.IsAndroid())
            {
                path = "/storage/emulated/0/Documents/";
            } else if(OperatingSystem.IsWindows())
            {
                path = Environment.GetEnvironmentVariable("USERPROFILE");
                path += @"\Desktop\";
            }
            
            Directory.SetCurrentDirectory(path);
            Console.Write($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}