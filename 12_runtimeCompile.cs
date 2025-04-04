using System;
using System.IO;

/*
    Runtime Platform Checks: If you want to avoid recompiling for
    each platform, use runtime checks.
*/
using System.Runtime.InteropServices;

namespace RuntimeCompile_v2
{
    public class Program
    {
        static void Main(string[] args)
        {
            string? path;
            if(RuntimeInformation.IsOSPlatform(OSPlatform.Windows))
            {
                path = Environment.GetEnvironmentVariable("USERPROFILE");
                path += @"\Desktop\";
            } else
            {
                path = "/storage/emulated/0/Documents/";
            }
            
            Directory.SetCurrentDirectory(path);
            Console.WriteLine($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}