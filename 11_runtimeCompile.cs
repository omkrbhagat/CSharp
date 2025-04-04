using System;
using System.IO;

namespace RuntimeCompile_v1
{
    public class Program
    {
        static void Main(string[] args)
        {
            if(OperatingSystem.IsAndroid())
            {
                Directory.SetCurrentDirectory("/storage/emulated/0/Documents/");
            } else if(OperatingSystem.IsWindows())
            {
                string user = Environment.GetEnvironmentVariable("USERPROFILE");
                Directory.SetCurrentDirectory(@$"{user}\Desktop\");
            }
            
            Console.WriteLine($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}