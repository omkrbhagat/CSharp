using System;
using System.IO;

namespace RuntimeCompile_v1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                You will get a warning: "Possible null reference argument for parameter
                'path' in 'Directory.SetCurrentDirectory(path)'" because:
                1. `path` is nullable(string?) - You initialized it as null, and while you
                assign it in if/else blocks, the compiler can't guarantee that one of those
                conditions will always be true.
                2. `Directory.SetCurrentDirectory(path)` expects a non-null string - Passing
                a potentially null value could cause a runtime `ArgumentNullException`.

                How to fix it:
                1. Ensure path is never null (best for known platforms) - If you're sure the code
                will only run on Android or Windows, you can throw an exception for unsupported
                platforms.
                2. Use the null-forgiving operator (!) if you're certain it won't be null.
                `Directory.SetCurrentDirectory(path!)`.
            */
            string? path = null;
            if(OperatingSystem.IsAndroid())
            {
                path = "/storage/emulated/0/Documents/";
            } else if(OperatingSystem.IsWindows())
            {
                path = Environment.GetEnvironmentVariable("USERPROFILE");
                path += @"\Desktop\";
            }else
            {
                throw new NotImplementedException("OS not supported");
            }

                Directory.SetCurrentDirectory(path);
            Console.Write($"pwd: {Directory.GetCurrentDirectory()}");
        }
    }
}